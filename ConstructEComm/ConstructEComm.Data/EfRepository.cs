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

            return fullErrorText;
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Table
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryable<T> TableNoTracking
        {
            get { throw new NotImplementedException(); }
        }
    }
}
