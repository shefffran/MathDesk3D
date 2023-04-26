using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownCube : MonoBehaviour
{

    [SerializeField] private GameObject spownObject;
    [SerializeField] private bool isOnSpownAndyObject = true;
    [SerializeField] private Vector3 position;
    public bool gameIsStated = true;


    void Start()
    {
        //spownObject = GameObject.FindGameObjectWithTag("Cube");
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Cube")
        {
            isOnSpownAndyObject = false;
        }
    }

    public void ObjectSpown()
    {
        if (gameIsStated)
        {
            Instantiate(spownObject, position, Quaternion.identity);
        }
    }
    
    
}

