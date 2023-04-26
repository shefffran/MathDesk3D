using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secondCamera : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] private GameObject camFirstPos;
    [SerializeField] private GameObject camSecondPos;
    [SerializeField] private GameObject HelperCanvas;
    [SerializeField] private GameObject Complete;
    [SerializeField] private GameObject False;
    [SerializeField] private Vector3 offsetOne;
    [SerializeField] private Vector3 offsetTow;
    public bool firstPos = true;
    public bool gameIsStarted = false;
    private bool helperCanv = true;
    [SerializeField] private SpownCube SpownCube;
    [SerializeField] private CompleteEnd CompleteEnd;
    [SerializeField] private Rigidbody desk;
    [SerializeField] private string tagName = "Cube";



    public void CamPosChange()
    {
        if(firstPos == true)
        {
            cam.transform.position = new Vector3(camSecondPos.transform.position.x, camSecondPos.transform.position.y, camSecondPos.transform.position.z);
            cam.transform.rotation = Quaternion.Euler(offsetTow.x, offsetTow.y, offsetTow.z);
            firstPos = false;
        }
        else if (firstPos == false)
        {
            cam.transform.position = new Vector3(camFirstPos.transform.position.x, camFirstPos.transform.position.y, camFirstPos.transform.position.z);
            cam.transform.rotation = Quaternion.Euler(offsetOne.x, offsetOne.y, offsetOne.z);
            firstPos = true;
        }
    }

    private void Start()
    {
        desk.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
    }
    
    public void StartBtn()
    {
        desk.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
        gameIsStarted = true;
       // SpownCube.gameIsStated = false;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void CubeFound()
    {
        desk.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;

    }

    public void DefoultPos()
    {
        cam.transform.position = new Vector3(camFirstPos.transform.position.x, camFirstPos.transform.position.y, camFirstPos.transform.position.z);
        cam.transform.rotation = Quaternion.Euler(offsetOne.x, offsetOne.y, offsetOne.z);
    }

    public void _HelperCanvas()
    {
        HelperCanvas.gameObject.SetActive(true);
        helperCanv = true;
    }

    public void _MissionComplite()
    {
        Complete.gameObject.SetActive(false);
        CompleteEnd.complete = false;
    }
    public void _MissionNotComplite()
    {
        False.gameObject.SetActive(false);
    }

    public void _HelperCanvasNuberTow()
    {
        HelperCanvas.gameObject.SetActive(false);
        helperCanv = false;
    }


    public void _Quit()
    {
        Application.Quit();
    }


}
