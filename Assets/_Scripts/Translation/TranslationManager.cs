using Assets._Scripts.Config;
using Assets._Scripts.Translation;
using Assets._Scripts.Translation.Model;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TranslationManager : MonoBehaviour
{
    private static Dictionary<string, string> localizationDictionary;
    public static Languages CurrentGameLanguage { get; private set; }

    public static void SetCurrentGameLanguage(Languages language)
    {
        CurrentGameLanguage = language;
    }

    public static Dictionary<string, string> GetLocalizationDictionary()
    {
        if (localizationDictionary == null)
        {
            localizationDictionary = FillLocalizationDictionary(CurrentGameLanguage);
        }

        return localizationDictionary;
    }

    private static Dictionary<string, string> FillLocalizationDictionary(Languages language)
    {
        string translationFileFullPath = GetTranslationFilePath(language);
        string fileData = LoadDataFromFile(translationFileFullPath);
        LocalizationItemsCollection loadedLocalizationCollection = ParseJSonFileAsLicalizationItemCollection(fileData);

        return InitLocalizationDictionary(loadedLocalizationCollection);
    }

    private static string LoadDataFromFile(string path)
    {
        string loadedData = string.Empty;

        if (!File.Exists(path))
        {
            File.ReadAllText(path);
        }

        if (string.IsNullOrEmpty(loadedData))
        {
            Debug.LogError("Can't found localization file at path: " + path);
        }

        return loadedData;
    }

    private static string GetTranslationFilePath(Languages language)
    {
        return Path.Combine(Application.streamingAssetsPath, Configuration.TranslationFilePaths[language]);
    }

    private static LocalizationItemsCollection ParseJSonFileAsLicalizationItemCollection(string loadedData)
    {
        return JsonUtility.FromJson<LocalizationItemsCollection>(loadedData);

    }

    private static Dictionary<string, string> InitLocalizationDictionary(LocalizationItemsCollection collection)
    {
        localizationDictionary = new Dictionary<string, string>();

        if (collection.ItemsCollection == null)
        {
            Debug.LogError("Loaded Collection is empty");
            return localizationDictionary;
        }

        foreach (LocalizationItem item in collection.ItemsCollection)
        {
            localizationDictionary.Add(item.ItemName, item.Text);
        }

        return localizationDictionary;
    }
}
