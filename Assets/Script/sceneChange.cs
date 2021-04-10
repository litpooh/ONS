using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    public string targetScene;
    public Vector2 playerPosition;
    //public VectorValue playerStorage;

    public void OnTriggerEnter2D(Collider2D collider){
        if (collider.CompareTag("Player") && !collider.isTrigger){
            SceneManager.LoadScene(targetScene);
            //playerStorage.initValue = playerPosition;
        }
    }
}
