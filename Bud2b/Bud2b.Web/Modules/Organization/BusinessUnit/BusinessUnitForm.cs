
namespace Bud2b.Organization.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Organization.BusinessUnit")]
    [BasedOnRow(typeof(Entities.BusinessUnitRow))]
    public class BusinessUnitForm
    {
        public String Name { get; set; }
        public Int32 ParentUnitId { get; set; }
        public Int32? TenantId { get; set; }
    }
}