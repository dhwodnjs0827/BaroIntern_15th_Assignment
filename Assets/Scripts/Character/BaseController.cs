using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BaseController : MonoBehaviour
{
    private Rigidbody2D rb;
    protected SpriteController spriteController;

    protected Vector2 movementDirection;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteController = GetComponent<SpriteController>();
    }

    private void FixedUpdate()
    {
        Move(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        direction *= 3f;
        rb.velocity = direction;
        Rotate(direction);
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
