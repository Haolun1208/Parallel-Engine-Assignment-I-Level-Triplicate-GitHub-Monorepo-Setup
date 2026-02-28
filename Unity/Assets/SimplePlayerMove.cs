using UnityEngine;

public class SimplePlayerMove : MonoBehaviour
{
    public float speed = 5f;
    

    private CharacterController cc;
    private Vector3 velocity;

    void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); 
        float z = Input.GetAxisRaw("Vertical");   

        Vector3 move = (transform.right * x + transform.forward * z).normalized;
        cc.Move(move * speed * Time.deltaTime);

        if (cc.isGrounded && velocity.y < 0)
            velocity.y = -2f;

        
        cc.Move(velocity * Time.deltaTime);
    }
}