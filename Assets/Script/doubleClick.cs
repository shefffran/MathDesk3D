using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class doubleClick : MonoBehaviour, IPointerDownHandler
{

    [SerializeField] GameObject cam;
    [SerializeField] GameObject secCam;
    [SerializeField] secondCamera secondCamera;
    public bool isDobleClicked = false;
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    private void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        secCam = GameObject.FindGameObjectWithTag("SecCam");
        secondCamera = secCam.GetComponent<secondCamera>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        clicked++;
        if (clicked == 1) clicktime = Time.time;

        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            if(secondCamera.firstPos == true)
            {
                cam.transform.position = new Vector3(this.transform.position.x, cam.transform.position.y, cam.transform.position.z);
                isDobleClicked = true;
            }
            else
            {
                cam.transform.position = new Vector3(this.transform.position.x, cam.transform.position.y, cam.transform.position.z);
                isDobleClicked = true;
            }

        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;

    }

}
