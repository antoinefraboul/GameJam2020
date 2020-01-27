using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject UI;
    public GameObject Door;
    bool doorOpen;
    bool doorOpenning;
        
    // Start is called before the first frame update
    void Start()
    {
        doorOpen = false;
        doorOpenning = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (doorOpen)
        //{
        //    animator.SetBool("doorOpen", true);
        //}

        if (doorOpen && !doorOpenning && Door.transform.position.y <= 3)
        {
            Door.transform.position += new Vector3(0, 2f, 0) * Time.deltaTime;
            if(Door.transform.position.y >= 3)
            {
                doorOpenning = true;
            }
        }

    }

    private void OnTriggerStay()
    {
        if (Input.GetButtonDown("Interaction1"))
        {
            doorOpen = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        UI.SetActive(true);
    }

    private void OnTriggerExit()
    {
        UI.SetActive(false);
    }
}
