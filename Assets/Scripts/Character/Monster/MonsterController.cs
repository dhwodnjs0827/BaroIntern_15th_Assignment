public class MonsterController : BaseController
{
    private Monster monster;
    
    protected override void Awake()
    {
        base.Awake();
        monster = GetComponent<Monster>();
    }

    private void Start()
    {
        moveSpeed = monster.Stat.MoveSpeed;
    }

    protected override void Update()
    {
        base.Update();
        var dir = GameManager.Instance.Player.transform.position - transform.position;
        movementDirection = dir.normalized;
        lookDirection = movementDirection;
    }
}
