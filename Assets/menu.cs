using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour{
    public void Start(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
