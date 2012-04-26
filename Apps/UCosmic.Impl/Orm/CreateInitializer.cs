using System.Data.Entity;

namespace UCosmic.Impl.Orm
{
    // ReSharper disable UnusedMember.Global
    public class CreateInitializer : CreateDatabaseIfNotExists<UCosmicContext>
    // ReSharper restore UnusedMember.Global
    {
        protected override void Seed(UCosmicContext context)
        {
            SqlInitializer.Seed(context);
        }
    }
}