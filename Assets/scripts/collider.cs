using UnityEngine;

public class collider : MonoBehaviour{
    public playerMovement m;
    void OnCollisionEnter(Collision collosionInfo){
        if(collosionInfo.collider.tag =="obstacle"){
            m.enabled = false;
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
