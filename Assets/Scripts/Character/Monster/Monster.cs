using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private MonsterSO data;

    private MonsterController monsterController;
    private SpriteController spriteController;
    private MonsterStatHandler monsterStatHandler;
    
    [SerializeField] private Projectile projectile;
    
    public MonsterSO Data => data;
    public MonsterStatHandler Stat => monsterStatHandler;
    public Projectile Projectile => projectile;

    private void Awake()
    {
        monsterController = GetComponent<MonsterController>();
        spriteController = GetComponent<SpriteController>();
        monsterStatHandler = GetComponent<MonsterStatHandler>();
    }
}
