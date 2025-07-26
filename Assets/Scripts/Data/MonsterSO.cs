using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSO : ScriptableObject
{
    public string MonsterID;
    public string Name;
    public string Description;
    public int Attack;
    public float AttackMul;
    public int MaxHP;
    public float MaxHPMul;
    public int AttackRange;
    public float AttackRangeMul;
    public float AttackSpeed;
    public float MoveSpeed;
    public int MinExp;
    public int MaxExp;
    public int[] DropItem;

    public void Init(MonsterData data)
    {
        MonsterID = data.MonsterID;
        Name = data.Name;
        Description = data.Description;
        Attack = data.Attack;
        AttackMul = data.AttackMul;
        MaxHP = data.MaxHP;
        MaxHPMul = data.MaxHPMul;
        AttackRange = data.AttackRange;
        AttackRangeMul = data.AttackRangeMul;
        AttackSpeed = data.AttackSpeed;
        MoveSpeed = data.MoveSpeed;
        MinExp = data.MinExp;
        MaxExp = data.MaxExp;
        DropItem = data.DropItem;
    }
}

[Serializable]
public class MonsterData
{
    public string MonsterID;
    public string Name;
    public string Description;
    public int Attack;
    public float AttackMul;
    public int MaxHP;
    public float MaxHPMul;
    public int AttackRange;
    public float AttackRangeMul;
    public float AttackSpeed;
    public float MoveSpeed;
    public int MinExp;
    public int MaxExp;
    public int[] DropItem;
}

[Serializable]
public class MonsterDataList
{
    public List<MonsterData> Monster;
}
