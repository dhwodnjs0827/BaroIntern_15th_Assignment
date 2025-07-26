using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    private Player player;
    [SerializeField] private ItemSO initialWeapon;
    
    private LayerMask monsterLayer;
    private Transform nearMonster;
    
    public Player Player => player;
    public Transform NearMonster => nearMonster;

    protected override void Awake()
    {
        base.Awake();
        
        monsterLayer = LayerMask.GetMask("Monster");
    }

    private void Start()
    {
        var res = Resources.Load<Player>("Prefabs/Character/Player");
        player = Instantiate(res);
        player.Equipment.SetWeapon(initialWeapon.ItemID);
    }

    private void Update()
    {
        CheckMonster();
    }

    private void CheckMonster()
    {
        Collider2D[] monsters = Physics2D.OverlapCircleAll(player.transform.position, player.Stat.AttackRange, monsterLayer);

        if (monsters.Length == 0)
        {
            return;
        }
        
        nearMonster = null;
        float minDistance = float.MaxValue;

        foreach (var monster in monsters)
        {
            float distance = Vector3.Distance(transform.position, monster.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearMonster = monster.transform;
            }
        }
    }
}
