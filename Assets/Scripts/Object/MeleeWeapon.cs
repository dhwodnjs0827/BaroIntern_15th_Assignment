using UnityEngine;

public class MeleeWeapon : Weapon
{
    private float rotateMul;
    
    private void Awake()
    {
        type = WeaponType.Melee;
        rotateMul = -100f;
    }

    public override void Attack(float attackSpeed)
    {
        transform.Rotate(Vector3.forward, rotateMul * attackSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Monster"))
        {
            var damaged = other.GetComponent<IDamage>();
            if (damaged != null)
            {
                damaged.Damaged(data.MaxAtk);
            }
        }
    }
}
