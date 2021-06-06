using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public Transform m_Ballmove;
    public Vector3 m_alpha;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            m_Ballmove.position.y + m_alpha.y,
            m_Ballmove.position.z + m_alpha.z);
    }
}
