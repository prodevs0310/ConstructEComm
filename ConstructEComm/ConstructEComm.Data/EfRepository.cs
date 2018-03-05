using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using ConstructEComm.Core;
using ConstructEComm.Core.Data;

namespace ConstructEComm.Data
{
    public partial class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _context;
        private IDbSet<T> _entities;

        public EfRepository(IDbContext context)
        {
            this._context = context;
        }

        protected string GetFullErrorText(DbEntityValidationException exc)
        {
            var msg = string.Empty;
            foreach (var validationError in exc.EntityValidationErrors)
                foreach (var error in validationError.ValidationErrors)
                    msg += string.Format("Property:{0} Error:{1}", error.PropertyName, error.ErrorMessage) + Environment.NewLine;

            return msg;
        }

        protected string GetFullErrorTextAndRollbackEntityChanges(DbEntityValidationException dbEx)
        {
            var fullErrorText = this.GetFullErrorText(dbEx);
            foreach (var entry in dbEx.EntityValidationErrors.Select(error => error.Entry))
            {
                if (entry == null)
                    continue;

                entry.State = EntityState.Unchanged;
            }

            this._context.SaveChanges();
            return fullErrorText;
        }

        public virtual T GetById(object id)
        {
            return this.Entities.Find(id);
        }


        public virtual void Insert(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("Entity is null");

                this.Entities.Add(entity);
                this._context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(this.GetFullErrorTextAndRollbackEntityChanges(ex));
            }
        }

        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (this._entities == null)
                    this._entities = this._context.Set<T>();
                return this._entities;
            }
        }


        public void Insert(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("Inserted entities is null");
                foreach (var entity in entities)
                    this.Entities.Add(entity);

                this._context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(this.GetFullErrorTextAndRollbackEntityChanges(ex));
            }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("updated entity is null");

                this._context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(this.GetFullErrorTextAndRollbackEntityChanges(ex), ex);
            }
        }

        public void Update(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("updated entity is null");

                this._context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(this.GetFullErrorTextAndRollbackEntityChanges(ex), ex);
            }
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("delete entity is null");

                this.Entities.Remove(entity);
                this._context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(this.GetFullErrorTextAndRollbackEntityChanges(ex), ex);
            }

        }

        public void Delete(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("delete entities are null");
                foreach (var entity in entities)
                    this.Entities.Remove(entity);

                this._context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw new Exception(this.GetFullErrorTextAndRollbackEntityChanges(ex), ex);
            }
        }

        public IQueryable<T> Table
        {
            get { return this.Entities; }
        }

        public IQueryable<T> TableNoTracking
        {
            get { return this.Entities.AsNoTracking(); }
        }
    }
}
