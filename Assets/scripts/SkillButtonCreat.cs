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
        int Skillcount = 0;

        foreach (Skill skill in HaveSkill)
        {
            GameObject instance = Instantiate(_Skillbutton, buttonParent);
            RectTransform rect = instance.GetComponent<RectTransform>();
            rect.anchoredPosition = spawnPosition + new Vector2(Skillcount * 1100f + -5000, -1900);
            Skillbutton button = instance.GetComponent<Skillbutton>();
            button.SkillPush(skill);
            Skillcount++;
        }
    }
}

