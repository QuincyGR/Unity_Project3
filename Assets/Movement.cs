using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [Range(-2, 2)] public float value;
    public float speed;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start ()
    {
        rigid = GetComponent <Rigidbody> ();
    }




    // Update is called once per frame
    void FixedUpdate ()
    {
        transform.position = new Vector3(value, transform.position.y, transform.position.z);
        rigid.velocity = (Vector3.forward * Time.deltaTime * Speed);

    }
    void LateUpdate {
            if (Input.GetButtonDown("Right"))
            {
                if (value == 2)
                    return;
                value += 2;
            }
            if (Input.GetButtonDown("Left"))
            {
                if (value == -2)
                    return;
                value -= 2;
            }
        
    }
}

