using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class LightManager : MonoBehaviour
{

    public GameObject[] lights;
    public List<Collider> colliders;
    public PostProcessVolume postProcessVolume;
    public MusicManager musicManager;
    public PlayerManager playerManager;
    public float lightTime;
    public float currentTime;

    public bool inShadow;

    public float bloomMax = 150f;
    public float bloomMin = 5f;

    private Bloom bloomLayer;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        inShadow = false;
        bloomLayer = null;
        postProcessVolume.profile.TryGetSettings(out bloomLayer);

        lights = GameObject.FindGameObjectsWithTag("Light");

        foreach(GameObject light in lights)
        {
            SphereCollider collider = light.AddComponent<SphereCollider>();
            LightCollider LC = light.AddComponent<LightCollider>();
            LC.lightManager = this;

            collider.radius = light.GetComponent<Light>().range/1.5f;
            collider.isTrigger = true;
            colliders.Add(collider);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(inShadow)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= lightTime)
            {
                playerManager.GameOver();
            }
        }
        else
        {
            currentTime = Mathf.Max(0, currentTime-Time.deltaTime);
        }

        bloomLayer.intensity.value = Mathf.Lerp(bloomMin, bloomMax, currentTime / lightTime);
        musicManager.SetStress(currentTime / lightTime);
    }

    public void isInShadow(bool shadow)
    {
        inShadow = shadow;
    }
}
