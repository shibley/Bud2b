using FluentMigrator;

namespace Bud2b.Migrations.DefaultDB
{
    [Migration(20170220210001)]
    public class DefaultDB_20170220_210001_MultiTenant
       : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("MeetingTypes")
                .AddColumn("TenantId").AsInt32()
                    .NotNullable().WithDefaultValue(1);

        }
    }
}