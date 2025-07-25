using UnityEngine;

public class MonsterController : BaseController
{
    private Monster monster;
    
    protected override void Awake()
    {
        base.Awake();
        monster = GetComponent<Monster>();
        moveSpeed = monster.Data.MoveSpeed;
    }

    private void Update()
    {
        var dir = GameManager.Instance.Player.transform.position - transform.position;
        movementDirection = dir.normalized;
    }
}
