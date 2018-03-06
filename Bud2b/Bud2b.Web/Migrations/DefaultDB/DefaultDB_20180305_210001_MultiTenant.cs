using FluentMigrator;

namespace Bud2b.Migrations.DefaultDB
{
    [Migration(20180305210001)]
    public class DefaultDB_20180305_210001_MultiTenant
       : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Tenants")
                .AddColumn("InstagramAccount").AsString()
                    .Nullable();

        }
    }
}