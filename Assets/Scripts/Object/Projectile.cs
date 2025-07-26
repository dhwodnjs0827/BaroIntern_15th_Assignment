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

    public void Fire(int atk)
    {
        var target = GameManager.Instance.NearMonster;
        if (target != null)
        {
            Vector2 dir = (target.position - transform.position).normalized;
            rb.velocity = dir * speed;
            damage = atk;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Monster"))
        {
            var damaged = other.GetComponent<IDamage>();
            if (damaged != null)
            {
                damaged.Damaged(damage);
                Destroy(gameObject);
            }
        }
    }
}