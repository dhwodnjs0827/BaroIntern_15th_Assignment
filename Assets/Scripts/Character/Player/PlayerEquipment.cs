using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{
    private Player player;
    [SerializeField] private Transform weaponPos;

    private Weapon equip;
    
    public Weapon Equip => equip;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        if (equip == null)
        {
            return;
        }
        equip.Attack(player.Stat.AttackSpeed);
    }

    public void SetWeapon(int id)
    {
        if (equip != null)
        {
            Destroy(equip.gameObject);
        }
        var prefab = Resources.Load<Weapon>($"Prefabs/Weapon/{id}");
        equip = Instantiate(prefab, weaponPos);
        equip.transform.SetParent(weaponPos);
    }
}
