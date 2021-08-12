using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zetcil;

public class ReloadText : MonoBehaviour
{
    [SerializeField] private GameObject[] textObj;

    public void ReloadLanguageText()
    {
        for (int i = 0; i < textObj.Length; i++)
        {
            if (textObj[i].GetComponent<UITextLanguage>())
            {
                textObj[i].GetComponent<UITextLanguage>().InitText();
            }
        }
    }
}
