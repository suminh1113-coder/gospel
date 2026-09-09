using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Skillbutton : MonoBehaviour
{
    public List<Skill> HaveSkill;
    private AttakManager _attakManager;
    private GameObject GameController;
    public ManaManager _ManaManager;
    public int SkillCost;
    void Start()
    {
        GameController = GameObject.FindWithTag("Attak_Manager");  
        _attakManager = GameController.GetComponent<AttakManager>();
        SkillCost = HaveSkill[0].Cost;
    }
    public void Click()
    {
        if (_attakManager.Target != null)
        {
            if (_ManaManager.Mana >= SkillCost)
            {
                _ManaManager.Mana -= SkillCost;
                _ManaManager.ManaTextChange();
                _attakManager.Attak(HaveSkill[0].Damage);
            }
            else
            {
                Debug.LogError("마나 없어여...뜌");
            }
        }
    }
    
}
