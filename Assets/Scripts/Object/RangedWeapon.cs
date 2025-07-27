using UnityEngine;

public class RangedWeapon : Weapon
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private Transform muzzlePoint;
    [SerializeField] private SpriteRenderer mainSprite;

    private float fireCooldown;
    private Vector2 targetDir;
    
    private void Awake()
    {
        type = WeaponType.Ranged;
        fireCooldown = 0;
    }

    private void Update()
    {
        Rotate();
    }

    public override void Attack(float attackSpeed)
    {
        fireCooldown += Time.deltaTime;

        if (fireCooldown >= attackSpeed)
        {
            FireProjectile();
            fireCooldown = 0f;
        }
    }

    private void FireProjectile()
    {
        if (targetDir != Vector2.zero)
        {
            var go = Instantiate(projectile);
            go.transform.position = muzzlePoint.position;
            go.Fire(targetDir, data.MaxAtk);
        }
    }

    private void Rotate()
    {
        var target = GameManager.Instance.NearMonster;
        if (target != null)
        {
            targetDir = (target.position - muzzlePoint.position).normalized;
        }
        
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
        mainSprite.flipY = !(angle > -90f && angle < 90f);
    }
}
