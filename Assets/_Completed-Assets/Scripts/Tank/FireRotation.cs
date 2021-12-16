using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRotation : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private float turnSpeed = 180.0f;
 

    private void Update()
    {
        //FireRotation();
    }

    //private void FireRotation()
    //{
    //    if (Input.GetKeyDown(KeyCode.Q))
    //    {
    //        float turn = turnSpeed * Time.deltaTime;
    //        Quaternion turnRotation = Quaternion.Euler(0.0f, turn, 0.0f);
    //        firePoint.MoveRotation(m_Rigidbody.rotation * turnRotation);
    //        Debug.Log("Ture left");
    //    }
    //    if (Input.GetKey(KeyCode.E))
    //    {
    //        float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;
    //        Quaternion turnRotation = Quaternion.Euler(0.0f, turn, 0.0f);
    //        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
    //        Debug.Log("Ture right");
    //    }
    //}
}
