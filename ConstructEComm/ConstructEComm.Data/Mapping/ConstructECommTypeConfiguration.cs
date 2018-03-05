using System.Data.Entity.ModelConfiguration;

namespace ConstructEComm.Data.Mapping
{
    public abstract class ConstructECommTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class 
    {
        public ConstructECommTypeConfiguration()
        {
            PostInitialize();
        }

        private void PostInitialize()
        {
            
        }
    }
}
