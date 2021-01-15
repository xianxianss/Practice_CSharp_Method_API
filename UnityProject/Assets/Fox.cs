using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0, 50f)]
    public float speed = 20;
    public Rigidbody2D rig;
    public SpriteRenderer sr;
    private float h;

    private void Move()
    {
        h = Input.GetAxisRaw("Horizontal");
        rig.AddForce(new Vector2(h * speed, 0));

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            sr.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sr.flipX = true;
        }

    }
   

    private void Update()
    {
       
        Move();
    }






}
