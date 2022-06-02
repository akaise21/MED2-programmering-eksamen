//Source: https://www.youtube.com/watch?v=qcXuvd7qSxg

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalizationButton : MonoBehaviour
{
    public bool active = false;
    public int localeID = 0;
    public void ChangeLocale()
    {
        if (localeID == 0)
        {
            localeID = 1;
        }
        else
        {
            localeID = 0;
        }

        if (active == true)
            return;
        StartCoroutine(SetLocale(localeID));
    }

    IEnumerator SetLocale(int _localeID)
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
        active = false;
    }
}
