using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestSO : ScriptableObject
{
    public string QuestID;
    public int Type;
    public int NPC;
    public string Name;
    public int Goal;
    public string Description;
    public int PriorID;
    public int GoalID;
    public int Exp;
    public int Gold;
    public bool Clear;
    public int Reward;

    public void Init(QuestData data)
    {
        QuestID = data.QuestID;
        Type = data.Type;
        NPC = data.NPC;
        Name = data.Name;
        Goal = data.Goal;
        Description = data.Description;
        PriorID = data.PriorID;
        GoalID = data.GoalID;
        Exp = data.Exp;
        Gold = data.Gold;
        Clear = data.Clear;
        Reward = data.Reward;
    }
}

[Serializable]
public class QuestData
{
    public string QuestID;
    public int Type;
    public int NPC;
    public string Name;
    public int Goal;
    public string Description;
    public int PriorID;
    public int GoalID;
    public int Exp;
    public int Gold;
    public bool Clear;
    public int Reward;
}

[Serializable]
public class QuestDataList
{
    public List<QuestData> Quest;
}