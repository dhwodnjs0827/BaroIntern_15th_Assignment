using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private MonsterSO data;

    private MonsterController monsterController;
    private SpriteController spriteController;
    private MonsterStatHandler monsterStatHandler;
    
    public MonsterSO Data => data;
    public MonsterStatHandler Stat => monsterStatHandler;

    private void Awake()
    {
        monsterController = GetComponent<MonsterController>();
        spriteController = GetComponent<SpriteController>();
        monsterStatHandler = GetComponent<MonsterStatHandler>();
    }
}
