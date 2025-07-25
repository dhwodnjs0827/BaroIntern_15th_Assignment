using UnityEngine;

public class PlayerStatHandler : BaseStatHandler
{
    private void Awake()
    {
        InitStat();
    }

    private void InitStat()
    {
        moveSpeed = 3f;
    }
}
