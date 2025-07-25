using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemSO : ScriptableObject
{
    public int ItemID;
    public string Name;
    public string Description;
    public int UnlockLev;
    public int MaxHP;
    public float MaxHPMul;
    public int MaxMP;
    public float MaxMPMul;
    public int MaxAtk;
    public float MaxAtkMul;
    public int MaxDef;
    public float MaxDefMul;
    public int Status;

    public void Init(ItemData data)
    {
        ItemID = data.ItemID;
        Name = data.Name;
        Description = data.Description;
        UnlockLev = data.UnlockLev;
        MaxHP = data.MaxHP;
        MaxHPMul = data.MaxHPMul;
        MaxMP = data.MaxMP;
        MaxMPMul = data.MaxMPMul;
        MaxAtk = data.MaxAtk;
        MaxAtkMul = data.MaxAtkMul;
        MaxDef = data.MaxDef;
        MaxDefMul = data.MaxDefMul;
        Status = data.Status;
    }
}

[Serializable]
public class ItemData
{
    public int ItemID;
    public string Name;
    public string Description;
    public int UnlockLev;
    public int MaxHP;
    public float MaxHPMul;
    public int MaxMP;
    public float MaxMPMul;
    public int MaxAtk;
    public float MaxAtkMul;
    public int MaxDef;
    public float MaxDefMul;
    public int Status;
}

[Serializable]
public class ItemDataList
{
    public List<ItemData> Item;
}
