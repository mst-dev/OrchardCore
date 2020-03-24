using System.Linq;

namespace OrchardCore.Localization.Extensions
{
    internal static class CultureDictionaryExtensions
    {
        public static string GetTranslationWithIgnoreContext(this CultureDictionary cultureDictionary, string key)
        {
            string translation = null;
            var dataAnnotationKey = cultureDictionary.Translations
                .Where(t => t.Key.Contains(key))
                .Select(t => t.Key)
                .FirstOrDefault();

            if (dataAnnotationKey != null)
            {
                translation = cultureDictionary[dataAnnotationKey];
            }

            return translation;
        }
    }
}
