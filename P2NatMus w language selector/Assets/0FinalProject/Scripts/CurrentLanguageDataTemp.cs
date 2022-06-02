using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLanguageDataTemp : MonoBehaviour
{
    private CurrentLanguageDataTemp _localeID;

    private void Start()
    {
        //_localeID = FindObjectOfType<CurrentLanguageData>();
    }
    public void ChangeLocale()
    {
        _localeID.ChangeLocale();
    }
}
