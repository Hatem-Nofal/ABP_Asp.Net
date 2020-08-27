using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ClothingShope.Localization
{
    public static class ClothingShopeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ClothingShopeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ClothingShopeLocalizationConfigurer).GetAssembly(),
                        "ClothingShope.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
