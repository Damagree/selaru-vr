using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireChecker : MonoBehaviour
{
    public UnityEvent eventAfterWin;
    bool isWin;

    private void Update()
    {
        if (!isWin)
        {
            CheckFireCount();
        }
    }

    public void CheckFireCount()
    {
        
        if (FireData.count <= 0)
        {
            isWin = true;
            eventAfterWin.Invoke();
        }
    }

}
