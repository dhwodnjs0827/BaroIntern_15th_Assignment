using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MonsterInfoUI : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI attack;
    [SerializeField] private TextMeshProUGUI hp;
    [SerializeField] private TextMeshProUGUI attackSpeed;
    [SerializeField] private TextMeshProUGUI moveSpeed;

    public void SetData(MonsterSO data, Sprite monsterImage)
    {
        image.sprite = monsterImage;
        name.text = $"이름: {data.Name}";
        description.text = $"설명: {data.Description}";
        attack.text = $"공격력: {data.Attack}";
        hp.text = $"체력: {data.MaxHP}";
        attackSpeed.text = $"공격 속도: {data.AttackSpeed}";
        moveSpeed.text = $"이동 속도: {data.MoveSpeed}";
    }
}
