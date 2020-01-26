using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public List<GameObject> m_lights;
    bool invert;

    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        invert = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (invert)
        {
            foreach (GameObject light in m_lights)
            {
                light.SetActive(!light.active);
            }
            invert = false;
        }
    }

    private void OnTriggerStay()
    {
        if (Input.GetButtonDown("Interaction1"))
        {
            invert = true;
        }


    }
    private void OnTriggerExit()
    {
        UI.SetActive(false);
    }

    private void OnTriggerEnter()
    {
        UI.SetActive(true);
    }
}
