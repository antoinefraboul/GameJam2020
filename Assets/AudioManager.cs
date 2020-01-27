using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource Audiotext;
    public AudioSource boucle;
    private float m_time;
    public float timer;
    public int SceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        Audiotext.volume = 1;
        Audiotext.Play();
        m_time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_time += Time.deltaTime;
        if (m_time >= timer)
        {
            if( SceneToLoad != 4)
            SceneManager.LoadScene(SceneToLoad);
            else 
            {
                boucle.volume = 0;
                boucle.Play();
            }
        }
    }

}
