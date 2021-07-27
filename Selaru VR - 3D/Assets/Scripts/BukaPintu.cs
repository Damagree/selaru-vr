using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BukaPintu : MonoBehaviour
{
    public Transform pintu;

    public Vector3 bukaPintu = new Vector3(0f, -90f, 0f);
    public Vector3 tutupPintu = new Vector3(0f, 0f, 0f);

    public float bukaSpeed = 5;

    private bool buka = false;
    // Start is called before the first frame update

    void Update()
    {
        if (buka)
        {
            //pintu.rotation = Vector3.Lerp(pintu.rotation, bukaPintu, 0);
        }
        else
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenPintu();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ClosePintu();
        }
    }

    public void ClosePintu()
    {
        buka = false;
    }
    public void OpenPintu()
    {
        buka = true;
    }
}
