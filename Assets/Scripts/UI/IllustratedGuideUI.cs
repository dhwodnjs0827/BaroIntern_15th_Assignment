using System.Collections.Generic;
using UnityEngine;

public class IllustratedGuideUI : MonoBehaviour
{
    [SerializeField] private MonsterInfoUI info;
    [SerializeField] private GameObject listUI;
    
    [SerializeField] private MonsterButton buttonPrefab;
    private List<MonsterButton> buttonList;

    private void Awake()
    {
        InitMonsterData();
        buttonList[0].Button.onClick?.Invoke();
    }

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

    private void InitMonsterData()
    {
        buttonList = new List<MonsterButton>();
        var monsterList = Resources.LoadAll<MonsterSO>("Data/SO/Monster");
        foreach (var monster in monsterList)
        {
            var button = Instantiate(buttonPrefab, listUI.transform);
            button.Init(monster, info);
            buttonList.Add(button);
        }
    }

    public void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
