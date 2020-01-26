using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Clipping_Manager : MonoBehaviour
{
    public float m_time;
    private float time;
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        m_time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_time += Time.deltaTime;
        if (m_time > 5)
        {
            m_time = 0;
            light.SetActive(!(light.activeInHierarchy));
        }
    }
}
