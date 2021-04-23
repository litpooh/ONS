using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    public string targetScene;
    public Vector2 playerPosition;
    public VectorValue playerStorage;
    public GameObject fadeIn;

    private void Awake() {
        if (fadeIn != null){
            GameObject panel = Instantiate(fadeIn, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }

    public void OnTriggerEnter2D(Collider2D collider){
        if (collider.CompareTag("Player") && !collider.isTrigger){
            playerStorage.initValue = playerPosition;
            SceneManager.LoadScene(targetScene);
        }
    }
}
