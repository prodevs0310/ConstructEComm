using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using ConstructEComm.Core.Domain.Seller;
using ConstructEComm.Data.Mapping;
using ConstructEComm.Data.Mapping.Category;
using ConstructEComm.Data.Mapping.Seller;

namespace ConstructEComm.Data
{
    public class ConstructECommContext : DbContext, IDisposable
    {
        public ConstructECommContext()
            : base("name=MccConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister =
                Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null &&
                    type.BaseType.IsGenericType &&
                    type.BaseType.GetGenericTypeDefinition() == typeof(ConstructECommTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }

        public virtual IDbSet<ConstructEComm.Core.Domain.Seller.Seller> SellerSet { get; set; }

        public virtual IDbSet<ConstructEComm.Core.Domain.Category.SellingCategory> CategorySet { get; set; } 

        void IDisposable.Dispose()
        {

        }
    }
}
