using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterStatHandler : MonoBehaviour, IDamage
{
    #region Variables

    private Monster monster;
    [SerializeField] private Image hpBar;
    
    private int level;
    private float attack;
    private float maxHP;
    private float curHP;
    private float attackRange;
    private float attackSpeed;
    private float moveSpeed;

    #endregion

    #region Properties

    public int Level => level;
    public float Attack => attack;
    public float MaxHP => maxHP;
    public float CurHP => curHP;
    public float AttackRange => attackRange;
    public float AttackSpeed => attackSpeed;
    public float MoveSpeed => moveSpeed;

    #endregion
    
    private void Awake()
    {
        monster = GetComponent<Monster>();
        SetInitialStats(monster.Data);
    }

    public void Damaged(int damage)
    {
        curHP -= damage;
        UpdateHpBar();
        if (curHP <= 0)
        {
            Dead();
        }
    }

    private void SetInitialStats(MonsterSO data)
    {
        level = 1;
        
        attack = data.Attack + level * data.AttackMul;
        maxHP = data.MaxHP + level * data.MaxHPMul;
        curHP = maxHP;
        attackRange = data.AttackRange + level * data.AttackRangeMul;
        attackSpeed = data.AttackSpeed;
        moveSpeed = data.MoveSpeed;

        UpdateHpBar();
    }

    private void UpdateHpBar()
    {
        hpBar.fillAmount = curHP / maxHP;
    }

    private void Dead()
    {
        for (int i = 0; i < monster.Data.DropItem.Length; i++)
        {
            var prefab = Resources.Load<DropItem>($"Prefabs/Item/{monster.Data.DropItem[i]}");
            var dropItem = Instantiate(prefab);
            dropItem.transform.position = transform.position;
        }
        gameObject.SetActive(false);
    }
}
