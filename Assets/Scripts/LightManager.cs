using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{

    public GameObject[] lights;
    public List<Collider> colliders;
    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("Light");

        foreach(GameObject light in lights)
        {
            SphereCollider collider = light.AddComponent<SphereCollider>();
            light.AddComponent<LightCollider>();
            collider.radius = light.GetComponent<Light>().range;
            collider.isTrigger = true;
            colliders.Add(collider);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
