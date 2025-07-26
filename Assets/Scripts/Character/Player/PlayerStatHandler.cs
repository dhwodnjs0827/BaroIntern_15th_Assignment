using UnityEngine;

public class PlayerStatHandler : MonoBehaviour, IDamage
{
    #region Variables

    private int level;
    private int maxHP;
    private float maxHPMul;
    private int curHP;
    private int attackRange;
    private float attackSpeed;
    private float moveSpeed;
    private int maxExp;
    private float maxExpMul;
    private int curExp;

    #endregion

    #region Properties
    
    public int MaxHP => maxHP;
    public float MaxHPMul => maxHPMul;
    public int CurHP => curHP;
    public int AttackRange => attackRange;
    public float AttackSpeed => attackSpeed;
    public float MoveSpeed => moveSpeed;
    public int MaxExp => maxExp;

    #endregion
    
    private void Awake()
    {
        SetInitialStats();
    }

    private void SetInitialStats()
    {
        level = 1;
        maxHP = 100;
        maxHPMul = 1.2f;
        curHP = maxHP;
        attackRange = 5;
        attackSpeed = 3f;
        moveSpeed = 3f;
        maxExp = 50;
        maxExpMul = 1.2f;
        curExp = 0;
    }

    public void Damaged(int damage)
    {
        
    }
}