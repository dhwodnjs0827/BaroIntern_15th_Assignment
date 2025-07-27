using UnityEngine;

public class MonsterController : BaseController
{
    private Monster monster;

    private float attackCoolDown;
    
    protected override void Awake()
    {
        base.Awake();
        monster = GetComponent<Monster>();
        attackCoolDown = 0;
    }

    private void Start()
    {
        moveSpeed = monster.Stat.MoveSpeed;
    }

    protected override void Update()
    {
        base.Update();
        TargetPlayer();
        Attack();
    }

    private void TargetPlayer()
    {
        var dir = GameManager.Instance.Player.transform.position - transform.position;
        movementDirection = dir.normalized;
        lookDirection = movementDirection;
    }
    
    private void Attack()
    {
        float distance = Vector2.Distance(GameManager.Instance.Player.transform.position, transform.position);
        if (distance > monster.Stat.AttackRange)
        {
            return;
        }
        attackCoolDown += Time.deltaTime;

        if (attackCoolDown >= monster.Stat.AttackSpeed)
        {
            FireProjectile();
            attackCoolDown = 0f;
        }
    }
    
    private void FireProjectile()
    {
        if (lookDirection != Vector2.zero)
        {
            var go = Instantiate(monster.Projectile);
            go.transform.position = (Vector2)transform.position + lookDirection * 1f;
            go.Fire(lookDirection, (int)monster.Stat.Attack);
        }
    }
}
