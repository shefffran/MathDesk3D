using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HowManyCubes : MonoBehaviour
{
    public GameObject inputFieldPos;
    public GameObject firstPos;
    public GameObject secondPos;
    public GameObject centerpos;
    public GameObject cube;
    public TargetSelector targetSelector;
    public string value;
    public float distance;
    public float transval;
    public float anyobj;
    bool oneTime = false;


    // Start is called before the first frame update
    void Start()
    {
         distance = secondPos.transform.position.x - firstPos.transform.position.x;
        DellitAll();
    }

    public void GetValue()
    {
       value  = inputFieldPos.GetComponent<TMP_InputField>().text;

            transval = distance / float.Parse(value);
            anyobj = transval;
            oneTime = true;

        centerpos.transform.position = new Vector3(0f, 4.35f, 0f);

            targetSelector.forlastGMN = false;



        if (float.Parse(value) < 16 && float.Parse(value) >= 0 )
        {
            DellitAll();
            
            for (int i = 0; i < float.Parse(value); i++)
            {
                Instantiate(cube, centerpos.transform.position, Quaternion.Euler(270f,10,0f));
                if (i % 2 == 1)
                {
                    centerpos.transform.position = new Vector3(centerpos.transform.position.x + transval, centerpos.transform.position.y, centerpos.transform.position.z);
                    transval = anyobj + transval;
                }
                else if (i % 2 == 0)
                {
                    centerpos.transform.position = new Vector3(centerpos.transform.position.x - transval, centerpos.transform.position.y, centerpos.transform.position.z);
                    transval = anyobj + transval;
                }
            }

        }
    }

    public void DellitAll()
    {

        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Cube");

        for (int i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i].gameObject);
        }

    }


}
