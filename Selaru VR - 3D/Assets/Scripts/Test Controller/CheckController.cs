using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckController : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textDebug;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            textDebug.text = "FIRE 1";
        }

        if (Input.GetButtonDown("Fire2"))
        {
            textDebug.text = "FIRE 2";
        }

        if (Input.GetButtonDown("Fire3"))
        {
            textDebug.text = "FIRE 3";
        }
    }
}
