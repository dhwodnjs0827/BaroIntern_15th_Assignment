using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerController playerController;
    private SpriteController spriteController;
    private PlayerStatHandler statHandler;
    
    public PlayerStatHandler Stat => statHandler;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        spriteController = GetComponent<SpriteController>();
        statHandler = GetComponent<PlayerStatHandler>();
    }
}
