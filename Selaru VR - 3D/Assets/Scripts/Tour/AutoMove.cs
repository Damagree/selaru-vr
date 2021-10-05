using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AutoMove : MonoBehaviour
{
    [SerializeField] PlayerMovement pm;
    [SerializeField] NavMeshAgent nma;
    [SerializeField] GameObject camera;

    public void EnablePm()
    {
        pm.enabled = true;
    }
    
    public void DisablePm()
    {
        pm.enabled = false;
    }

    private void Update()
    {
        if (Vector3.Distance(nma.destination, transform.position) <= nma.stoppingDistance)
        {
            EnablePm();
        }
        else
        {
            camera.transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            DisablePm();
        }
    }

}
