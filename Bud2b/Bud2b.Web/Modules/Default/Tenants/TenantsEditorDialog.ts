
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Bud2b.Default {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TenantsEditorDialog extends Common.GridEditorDialog<TenantsRow> {
        protected getFormKey() { return TenantsForm.formKey; }
                protected getLocalTextPrefix() { return TenantsRow.localTextPrefix; }
        protected getNameProperty() { return TenantsRow.nameProperty; }
        protected form = new TenantsForm(this.idPrefix);
    }
}