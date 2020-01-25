using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    AudioSource lightMusic;
    AudioSource shadowMusic;
    AudioSource stressMusic;
    public float stressTime;

    private float stress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stress > 0)
        {
            lightMusic.volume = Mathf.Lerp(0,1, stress);
            shadowMusic.volume = Mathf.Lerp(1,0, stress);
            stressMusic.volume = Mathf.Lerp(1,0, stress/stressTime);
        }
        
        else
        {
            lightMusic.volume = Mathf.Lerp(1,0, stress);
            shadowMusic.volume = Mathf.Lerp(0,1, stress);
            stressMusic.volume = Mathf.Lerp(0,1, stress/stressTime);
        }
    }

    public void SetStress(float value)
    {
        stress = value;
    }
}
