using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Cubeobj;
    Vector3 Pos;
    bool next;
    float[] posX;
    float[] posZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        StartCoroutine (Waitsys())
    }\

    IEnumerator WaitSys()
    {
        yield return new WaitForSeconds(1f);
        next = true;
        Generate();
    }
    void Generate()
    {
        if (!next)
            return;
        int i = Random.Range(0, 3);
        Pos.x = posX[i];
        Pos.z += posZ[i];
        GameObject CubeClone = Instantiate(Cubeobj,Pos,Cubeobj,transform.rotation)
            CubeClone.GetComponent<CubeScript>().myNum = value;
            value += 1;
            next = false;
    }
    public void Message(int i)
    {
        if(lastpos == i)
        {
            Debug.log("Lost!!");
        } else
        {
            Debug.log("Won!!");
            Application.LoadLevel(0);
        }
    }
}
