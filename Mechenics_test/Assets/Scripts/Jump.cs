using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;

    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (rb.velocity.y >= 0.1f)
        {
            isGrounded = false;
        }
  

        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
 
        }
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor") {
            isGrounded = true;
        }
    }
}