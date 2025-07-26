using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BaseController : MonoBehaviour
{
    private Rigidbody2D rb;
    protected SpriteController spriteController;
    
    protected float moveSpeed;
    protected Vector2 movementDirection;

    protected Vector2 lookDirection;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteController = GetComponent<SpriteController>();
    }

    protected virtual void FixedUpdate()
    {
        Move(movementDirection);
    }

    protected virtual void Update()
    {
        Rotate(lookDirection);
    }

    private void Move(Vector2 direction)
    {
        direction *= moveSpeed;
        rb.velocity = direction;
    }

    private void Rotate(Vector2 direction)
    {
        if (direction.x > 0)
        {
            spriteController.MainSprite.flipX = false;
        }
        else if (direction.x < 0)
        {
            spriteController.MainSprite.flipX = true;
        }
    }
}
