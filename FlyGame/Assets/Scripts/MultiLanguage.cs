using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization;

public class MultiLanguage : MonoBehaviour
{
    void Awake()
    {
        LocalizationManager.Read();

        LocalizationManager.Language = "Ukrainian";


    }
    public void Language(string language)
    {
        LocalizationManager.Language = language;
    }
}
