using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLanguageData : MonoBehaviour
{
    [HideInInspector]
    public int currentLocale = 0;

    private static CurrentLanguageData _instance;
    private void Awake() // This Awake method makes sure that this instance of the class is the only one present in the scene by using DontDestroyOnLoad and Destroy
    {
        if (_instance != null && _instance != this)
            Destroy(this.gameObject);
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void ChangeCurrentPageOnSceneLoad(int localeID) // This method is used by the navigation bar to keep track of which page is currently active
    {
        currentLocale = localeID;
    }
}