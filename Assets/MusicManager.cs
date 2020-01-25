using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource lightMusic;
    public AudioSource shadowMusic;
    public AudioSource stressMusic;

    private float stress;
    // Start is called before the first frame update
    void Start()
    {
        lightMusic.volume = 0;
        shadowMusic.volume = 1;
        stressMusic.volume = 0;
        lightMusic.Play();
        shadowMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (stress > 0)
        {
            stressMusic.volume = Mathf.Lerp(1,0, stress);
            lightMusic.volume = 1;
        }
        
        else
        {
            stressMusic.volume = Mathf.Lerp(0,1, stress);
            lightMusic.volume = 0;
        }
    }

    public void SetStress(float value)
    {
        stress = value;
    }
}
