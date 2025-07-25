using UnityEngine;

public class SpriteController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    [SerializeField] private SpriteRenderer mainSprite;
    
    public Animator Animator => animator;
    public SpriteRenderer MainSprite => mainSprite;
    
    
}
