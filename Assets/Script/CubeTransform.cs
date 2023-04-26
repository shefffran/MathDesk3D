using UnityEngine;

public class CubeTransform : MonoBehaviour
{
    private Renderer renderer;
    public bool cubeSelected;


    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (cubeSelected)
        {

            renderer.material.color = Color.red;    
        }
        else
        {

            renderer.material.color = Color.white;
        }
        
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }
}
