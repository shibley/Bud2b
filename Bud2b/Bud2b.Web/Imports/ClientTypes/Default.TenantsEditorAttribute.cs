using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bud2b.Default
{
    public partial class TenantsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Bud2b.Default.TenantsEditor";

        public TenantsEditorAttribute()
            : base(Key)
        {
        }
    }
}

