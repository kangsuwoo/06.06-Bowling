using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove1 : MonoBehaviour
{
    Rigidbody rigid;
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = Vector3.up;
    }
   
    void Update()
    {
       if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigid.AddForce(0, 0, -1, ForceMode.Impulse);
          
        }
        
    }
}
