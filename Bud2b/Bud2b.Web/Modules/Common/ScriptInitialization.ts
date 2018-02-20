namespace Bud2b.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('Bud2b');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}