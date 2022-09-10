using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desk : MonoBehaviour
{
    private GameObject[] m_Desk;
    // Start is called before the first frame update
    void Start()
    {
        m_Desk = GameObject.FindGameObjectsWithTag("desks");
        for(int i=0;i<m_Desk.Length;i++)
        {
            Debug.Log(m_Desk[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            DeskUp();
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            Deskdown();
        }
    }
    void DeskUp()
    {
        for (int i = 0; i < m_Desk.Length; i++)
        {
            m_Desk[i].GetComponent<Transform>().Translate(Vector3.up * 2, Space.Self);
        }
    }
    void Deskdown()
    {
        for (int i = 0; i < m_Desk.Length; i++)
        {
            m_Desk[i].GetComponent<Transform>().Translate(Vector3.down * -2, Space.Self);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "student")
        {
            DeskUp();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "student")
        {
            Deskdown();
        }
    }
}
