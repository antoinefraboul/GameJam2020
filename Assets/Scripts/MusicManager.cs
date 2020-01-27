using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource shadowMusic;
    public AudioSource stressMusic;

    public AudioSource Intro;

    private float stress;
    // Start is called before the first frame update
    void Start()
    {
        stressMusic.volume = 0;
        stressMusic.Play();
        shadowMusic.volume = 0;
        shadowMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (stress > 0)
        {
            stressMusic.volume = Mathf.Lerp(0.5f,0, stress);
        }
        
        else
        {
            stressMusic.volume = Mathf.Lerp(0,0.5f, stress);
        }
        if(Intro != null)
        {
            if(!Intro.isPlaying){
            shadowMusic.volume = 0.5f;
            }
        }
        
    }

    public void SetStress(float value)
    {
        stress = value;
    }
}
