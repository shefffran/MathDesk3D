using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerTest : MonoBehaviour, IPointerClickHandler
{
    public GameObject selectedCube;
    public GameObject lastselectedCube;
    private CubeTransform scriptableObject;
    

    private void Start()
    {
        scriptableObject = this.GetComponent<CubeTransform>();
    }


    public void OnPointerClick(PointerEventData eventData)
    {

    } 



    private void CubeTransform()
    {
        if (scriptableObject.cubeSelected == true)
        {
            Debug.Log("Gmpcru");
        }
        else
        {
            scriptableObject.cubeSelected = false;
        }
    }

}
