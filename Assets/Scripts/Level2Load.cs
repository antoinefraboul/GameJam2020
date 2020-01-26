using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Load : MonoBehaviour
{
    public GameObject level2;
    public GameObject level1;

    public GameObject player;
    public Vector3 position;
    public GameObject camera;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        level2.SetActive(true);
        camera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 3)
        {
            player.transform.position = position;
            level1.SetActive(false);
        }
    }
}
