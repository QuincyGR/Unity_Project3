using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public int myNum;
    private GenerateCube generate;

    void Start()
    {
        generate = GetComponent<GenerateCube>();
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == " player ")
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
