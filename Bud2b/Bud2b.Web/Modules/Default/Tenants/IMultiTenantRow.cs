using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serenity.Data;

namespace Bud2b
{
    public interface IMultiTenantRow
    {
        Int32Field TenantIdField { get; }
    }
}