using UnityEngine;

public enum WeaponType
{
    Melee,
    Ranged,
}

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected ItemSO data;
    protected WeaponType type;

    public ItemSO Data => data;
    public WeaponType Type => type;

    public abstract void Attack(float attackSpeed);
}
