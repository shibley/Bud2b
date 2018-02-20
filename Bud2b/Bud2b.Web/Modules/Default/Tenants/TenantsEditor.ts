
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Bud2b.Default {
    
    @Serenity.Decorators.registerClass()
    export class TenantsEditor extends Common.GridEditorBase<TenantsRow> {
        protected getColumnsKey() { return 'Default.Tenants'; }
        protected getDialogType() { return TenantsEditorDialog; }
                protected getLocalTextPrefix() { return TenantsRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}