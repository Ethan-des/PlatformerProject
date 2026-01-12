using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed; //To manage player's speed
    private Rigidbody2D body;//To manage player's rigid body

    //Initializes variables or states before application starts
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    //Update runs on every frame of the game
    //Made for recording playing inputs
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed,body.velocity.y);

        if(Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, speed);
        }
    }
}
