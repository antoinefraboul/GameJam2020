using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;
using Invector.vCharacterController;
public class DeathManager : MonoBehaviour
{
    public AudioSource[] music;
    public vThirdPersonInput controller;
    public GameObject gameOver;
    private Bloom bloomLayer;
    private LensDistortion lensDistortion;
    public PostProcessVolume postProcessVolume;

    float time;
    public float DeathTime;
    // Start is called before the first frame update
    void Start()
    {
        controller.enabled = false;
        bloomLayer = null;
        postProcessVolume.profile.TryGetSettings(out bloomLayer);
        postProcessVolume.profile.TryGetSettings(out lensDistortion);
        time = 0;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        bloomLayer.intensity.value = Mathf.Lerp(150, 200, time/ DeathTime);
        lensDistortion.intensity.value =  Mathf.Lerp(0, 100, time/ DeathTime);
        int musicNb = Random.Range(0,3);
        music[musicNb].Play();
        if (time >= DeathTime)
        {
            gameOver.SetActive(true);
        }
        if(time >= DeathTime + 2 )
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            if(index != 0)
            gameObject.GetComponent<SceneLoader>().ChangeScene(index);
            else gameObject.GetComponent<SceneLoader>().ChangeScene(3);
        }
    }
}
