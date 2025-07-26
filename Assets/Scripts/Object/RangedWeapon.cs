using UnityEngine;

public class RangedWeapon : Weapon
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private Transform muzzlePoint;

    private float fireCooldown;
    
    private void Awake()
    {
        type = WeaponType.Ranged;
        fireCooldown = 0;
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
        var go = Instantiate(projectile);
        go.transform.position = muzzlePoint.position;
        go.Fire(data.MaxAtk);
    }
}
