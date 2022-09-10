using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class student : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    private Transform m_Transform;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();
        m_Transform = gameObject.GetComponent<Transform>();
        m_Rigidbody.MovePosition(m_Transform.position + Vector3.forward * 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.right * 0.2f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.left * 0.2f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.forward * 0.2f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_Rigidbody.MovePosition(m_Transform.position + Vector3.back * 0.2f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "ground")
        {
            Debug.Log("Enter" + collision.gameObject.name);
        }
    }
}
