using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteEnd : MonoBehaviour
{
    public GameObject deskCube;
    public secondCamera secondCamera;
    public GameObject Completee;
    public GameObject False;
    public bool complete = false;
    private bool completFalse = false;
    public float maxRotate;
    public float rot;


    private void FixedUpdate()
    {
        rot = deskCube.transform.eulerAngles.z;

        if (secondCamera.gameIsStarted == true)
        {
            if(deskCube.transform.eulerAngles.z < maxRotate || deskCube.transform.eulerAngles.z > 360 - maxRotate)
            {
                StartCoroutine(ExecuteAfterTime(3f));

            }

        }

         if (complete)
         {
              Completee.SetActive(true);
         }

    }

    IEnumerator ExecuteAfterTime(float timeInSec)   
    {
        yield return new WaitForSeconds(timeInSec);
        if (deskCube.transform.eulerAngles.z < maxRotate || deskCube.transform.eulerAngles.z > 360 - maxRotate)
        {
            if (!completFalse)
            {
                complete = true;
                completFalse = true;
            }

        }
        else
        {

            False.SetActive(true);
        }
    }
}
