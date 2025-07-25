#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

//TODO: 코드 확장성 고려해서 수정 필요
public class CreateSOFromJSON
{
    [MenuItem("Tools/SO/Item")]
    public static void ItemSO()
    {
        TextAsset jsonFile = Resources.Load<TextAsset>("Data/JSON/Item");
        ItemDataList list = JsonUtility.FromJson<ItemDataList>(jsonFile.text);
        var datas = list.Item;
        foreach (var data in datas)
        {
            ItemSO so = ScriptableObject.CreateInstance<ItemSO>();
            so.Init(data);
            
            AssetDatabase.CreateAsset(so, $"Assets/Resources/Data/SO/Item/{data.ItemID}.asset");
            AssetDatabase.SaveAssets();
        }
    }

    [MenuItem("Tools/SO/Monster")]
    public static void MonsterSO()
    {
        TextAsset jsonFile = Resources.Load<TextAsset>("Data/JSON/Monster");
        MonsterDataList list = JsonUtility.FromJson<MonsterDataList>(jsonFile.text);
        var datas = list.Monster;
        foreach (var data in datas)
        {
            MonsterSO so = ScriptableObject.CreateInstance<MonsterSO>();
            so.Init(data);
            
            AssetDatabase.CreateAsset(so, $"Assets/Resources/Data/SO/Monster/{data.MonsterID}.asset");
            AssetDatabase.SaveAssets();
        }
    }
    
    [MenuItem("Tools/SO/Quest")]
    public static void QuestSO()
    {
        TextAsset jsonFile = Resources.Load<TextAsset>("Data/JSON/Quest");
        QuestDataList list = JsonUtility.FromJson<QuestDataList>(jsonFile.text);
        var datas = list.Quest;
        foreach (var data in datas)
        {
            QuestSO so = ScriptableObject.CreateInstance<QuestSO>();
            so.Init(data);
            
            AssetDatabase.CreateAsset(so, $"Assets/Resources/Data/SO/Quest/{data.QuestID}.asset");
            AssetDatabase.SaveAssets();
        }
    }
}
#endif