using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        gameObject.GetComponent<SceneLoader>().ChangeScene(index);
    }
}
