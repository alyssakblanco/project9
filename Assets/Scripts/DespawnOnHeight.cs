using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class DespawnOnHeight : MonoBehaviour {
    // initialize
    void Start(){}

    // check for position
    void Update(){
        // if player is under floor, go to game over
        if(transform.position.y <= -1){
            SceneManager.LoadScene("GameOver");

            // destroy sound
            var whisperSource = GameObject.Find("WhisperSource");
            GameObject.Destroy(whisperSource);
        }
    }
}