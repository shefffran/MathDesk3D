using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCubeFinder : MonoBehaviour
{
    [SerializeField] private GameObject[] allcubes;


    private void Update()
    {
        allcubes = GameObject.FindGameObjectsWithTag("Cube");
    }

}
