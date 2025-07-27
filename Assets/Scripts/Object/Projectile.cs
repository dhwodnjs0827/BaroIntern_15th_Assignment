using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private int damage;
    private float speed;

    private void Awake()
    {
        speed = 4f;
    }

    public void Fire(Vector2 dir, int atk)
    {
        rb.velocity = dir * speed;
        damage = atk;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var damaged = other.GetComponent<IDamage>();
        if (damaged != null)
        {
            damaged.Damaged(damage);
        }
        Destroy(gameObject);
    }
}