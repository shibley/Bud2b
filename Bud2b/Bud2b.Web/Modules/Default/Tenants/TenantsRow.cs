
namespace Bud2b.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;
    using Bud2b.Administration;

    [ConnectionKey("Default"), TableName("[dbo].[Tenants]"), DisplayName("Tenants"), InstanceName("Tenant"), TwoLevelCached]
    [ReadPermission(PermissionKeys.Tenants)]
    [ModifyPermission(PermissionKeys.Tenants)]
    [LookupScript("Administration.Tenant")]
    public sealed class TenantsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Tenant Id"), Identity]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Tenant Name"), Size(100), NotNull, QuickSearch]
        public String TenantName
        {
            get { return Fields.TenantName[this]; }
            set { Fields.TenantName[this] = value; }
        }

        [DisplayName("Tenant Domain"), Size(100), QuickSearch]
        public String Domain
        {
            get { return Fields.Domain[this]; }
            set { Fields.Domain[this] = value; }
        }

        [DisplayName("Instagram Account"), Size(100), QuickSearch]
        public String InstagramAccount
        {
            get { return Fields.InstagramAccount[this]; }
            set { Fields.InstagramAccount[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.TenantId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.TenantName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TenantsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TenantId;
            public StringField TenantName;
            public StringField Domain;
            public StringField InstagramAccount;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Tenants";
            }
        }
    }
}
