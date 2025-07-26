using UnityEngine;
using UnityEngine.UI;

public class MonsterButton : MonoBehaviour
{
    private MonsterInfoUI info;
    [SerializeField] private Button button;
    [SerializeField] private Image image;

    public void Init(MonsterSO monsterSO, MonsterInfoUI ui)
    {
        var multiSprite = Resources.LoadAll<Sprite>($"Sprites/{monsterSO.MonsterID}");
        foreach (var sprite in multiSprite)
        {
            if (sprite.name.Equals("Run 0"))
            {
                image.sprite = sprite;
            }
        }
        info = ui;
        button.onClick.AddListener(() => info.SetData(monsterSO, image.sprite));
    }
}
