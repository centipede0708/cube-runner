using UnityEngine;
using UnityEngine.SceneManagement;

 public class complete : MonoBehaviour{
   public void Complete(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
}
