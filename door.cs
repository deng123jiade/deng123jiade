using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private Door1 m_Door;
    // Start is called before the first frame update
    void Start()
    {
        m_Door = GameObject.Find("ff").GetComponent<Door1>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name =="student")
        {
            m_Door.OpenDoor();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name=="student")
        {
            m_Door.CloseDoor();
        }
    }
}
