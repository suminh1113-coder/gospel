using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "Skill", menuName = "SkillManager/Skill")]
public class Skill : ScriptableObject
{
    public string SkillName;
    public Sprite SkillIcon;
    public int Damage;
    public int Cost;
}
