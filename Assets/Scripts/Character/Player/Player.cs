using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerController playerController;
    private SpriteController spriteController;
    private PlayerStatHandler playerStatHandler;
    private PlayerEquipment playerEquipment;

    private BoxCollider2D col;
    
    public PlayerStatHandler Stat => playerStatHandler;
    public PlayerEquipment Equipment => playerEquipment;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        spriteController = GetComponent<SpriteController>();
        playerStatHandler = GetComponent<PlayerStatHandler>();
        playerEquipment = GetComponent<PlayerEquipment>();
        
        col = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        IInteract interact = other.GetComponent<IInteract>();
        if (interact != null)
        {
            interact.Interact();
            Debug.Log("트리거");
        }
    }
}
