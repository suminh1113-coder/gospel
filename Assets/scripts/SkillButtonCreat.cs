using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class SkillButtonCreat : MonoBehaviour
{
    public List<Skill> HaveSkill;
    public GameObject _Skillbutton;
    [SerializeField] private Vector2 spawnPosition;
    [SerializeField] private RectTransform buttonParent;
    void Start()
    {
        int index = 0;

        foreach (Skill skill in HaveSkill)
        {
            GameObject instance = Instantiate(_Skillbutton, buttonParent);

            RectTransform rect = instance.GetComponent<RectTransform>();

            // 생성할 때마다 오른쪽으로 이동
            rect.anchoredPosition = spawnPosition + new Vector2(index * 4000f + -15500, -6500);

            Skillbutton button = instance.GetComponent<Skillbutton>();
            button.SkillPush(skill);

            index++;
        }
    }
}

