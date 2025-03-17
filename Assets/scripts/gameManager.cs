using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour{
    public GameObject levelComplete;
    public float RestartDelay = 2f;
    bool gameHasEnded = false;
    public void EndGame(){
        if(!gameHasEnded){
            gameHasEnded = true;
            Invoke("restart",RestartDelay);
        }
    }

    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void completeLevel(){
        levelComplete.SetActive(true);
    }
}
