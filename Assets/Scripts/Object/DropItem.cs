using DataDeclaration;
using UnityEngine;

public class DropItem : MonoBehaviour, IInteract
{
    [SerializeField] private ItemSO data;
    
    public void Interact()
    {
        if (data.ItemID >= Constants.WEAPON_ITEM_INDEX && data.ItemID < Constants.CONSUME_ITEM_INDEX)
        {
            GameManager.Instance.Player.Equipment.SetWeapon(data.ItemID);
        }
        else if (data.ItemID >= Constants.CONSUME_ITEM_INDEX && data.ItemID < Constants.ETC_ITEM_INDEX)
        {
            //TODO: 소비 아이템
            //GameManager.Instance.Player.Stat.
        }
        else
        {
            
        }
        Destroy(gameObject);
    }
}
