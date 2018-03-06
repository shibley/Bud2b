using FluentMigrator;

namespace Bud2b.Migrations.DefaultDB
{
    [Migration(20180220210001)]
    public class DefaultDB_20180220_210001_MultiTenant
       : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Tenants")
                .AddColumn("Domain").AsString()
                    .Nullable();

        }
    }
}