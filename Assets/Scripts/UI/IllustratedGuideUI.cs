using UnityEngine;

public class IllustratedGuideUI : MonoBehaviour
{
    [SerializeField] private MonsterInfoUI info;
    [SerializeField] private GameObject listUI;
    
    [SerializeField] private MonsterButton buttonPrefab;

    private void Awake()
    {
        InitMonsterData();
    }

    private void InitMonsterData()
    {
        var monsterList = Resources.LoadAll<MonsterSO>("Data/SO/Monster");
        foreach (var monster in monsterList)
        {
            var button = Instantiate(buttonPrefab, listUI.transform);
            button.Init(monster, info);
        }
    }

    public void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
