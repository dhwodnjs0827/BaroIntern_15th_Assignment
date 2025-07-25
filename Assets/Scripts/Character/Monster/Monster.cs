using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private MonsterSO data;
    
    private SpriteController spriteController;
    
    public MonsterSO Data => data;
}
