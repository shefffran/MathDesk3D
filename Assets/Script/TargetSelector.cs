using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TargetSelector : MonoBehaviour
{
    public Camera camera;
    public GameObject inputFieldMass;
    public GameObject inputFieldPos;
    public HowManyCubes howManycubes;
    //change to private
    public GameObject selectedCube;
    //------------------
    private string textinp;
    public float mas;
    RaycastHit hitInfo;
    [SerializeField] float masinput;
    [SerializeField] float posInput;

    public bool forlastGMN = false;
     private GameObject lastGMN;

    public void GetMass()
    {
        mas = float.Parse(inputFieldMass.GetComponent<TMP_InputField>().text);
    }
    public void ConfirCange()
    {
        masinput = float.Parse(inputFieldMass.GetComponent<TMP_InputField>().text);
        posInput = float.Parse(inputFieldPos.GetComponent<TMP_InputField>().text);

        if(masinput < 1000 && posInput > -15.5f && posInput < 15.5f)
        {
            selectedCube.GetComponent<Rigidbody>().mass = masinput;
            selectedCube.GetComponent<Transform>().transform.position = new Vector3(posInput,selectedCube.transform.position.y, selectedCube.transform.position.z);
        }


    }
    
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hitInfo))
            {
                if(hitInfo.collider.gameObject.GetComponent<CubeTransform>() != null)
                {

                    //--------------------------------Info Set----------------------------------------------
                    var input = hitInfo.collider.gameObject.GetComponent<Rigidbody>().mass;
                    var posInput = hitInfo.collider.gameObject.GetComponent<Transform>().position.x;


                    inputFieldMass.GetComponent<TMP_InputField>().text = input.ToString();
                    inputFieldPos.GetComponent<TMP_InputField>().text = posInput.ToString();


                    selectedCube = hitInfo.collider.gameObject;
                    //--------------------------------------------------------------------------------------






                    //hitInfo.collider.gameObject.GetComponent<Rigidbody>().mass = mas; 

                    ///---------------------------------Red Color-------------------------------------------
                    if (forlastGMN)
                        lastGMN.GetComponent<CubeTransform>().cubeSelected = false;

                    hitInfo.collider.gameObject.GetComponent<CubeTransform>().cubeSelected = true;
                    lastGMN = hitInfo.collider.gameObject;
                    forlastGMN = true;

                }
            }
        }
    }

}
