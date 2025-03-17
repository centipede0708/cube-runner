using UnityEngine;

public class playerMovement : MonoBehaviour
{   
    public Rigidbody rb;
    public float forwardForce = 200f;
    public float sideForce = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce);

        if(Input.GetKey("d")){
            rb.AddForce(sideForce,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideForce,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y<-1.5f){
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
