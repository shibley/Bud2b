

namespace Bud2b.Meeting.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Default"), DisplayName("Agenda Types"), InstanceName("Agenda Type"), TwoLevelCached]
    [ReadPermission(PermissionKeys.General)]
    [ModifyPermission(PermissionKeys.Management)]
    [LookupScript("Meeting.MeetingAgendaType")]
    public sealed class MeetingAgendaTypeRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Agenda Type Id"), Identity]
        public Int32? AgendaTypeId
        {
            get { return Fields.AgendaTypeId[this]; }
            set { Fields.AgendaTypeId[this] = value; }
        }

        [Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        public Int32Field TenantIdField
        {
            get { return Fields.TenantId; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch, Width(350)]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.AgendaTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MeetingAgendaTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field AgendaTypeId;
            public StringField Name;
            public readonly Int32Field TenantId;

            public RowFields()
                : base("MeetingAgendaTypes")
            {
                LocalTextPrefix = "Meeting.MeetingAgendaType";
            }
        }
    }
}