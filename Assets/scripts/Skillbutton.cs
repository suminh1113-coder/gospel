using UnityEngine;

public class Skillbutton : MonoBehaviour
{
    private AttakManager _attakManager;
    private GameObject GameController;
    public ManaManager _ManaManager;
    public int SkillCost;
    void Start()
    {
        GameController = GameObject.FindWithTag("Attak_Manager");  
        _attakManager = GameController.GetComponent<AttakManager>();
    }
    public void Click()
    {
        if (_attakManager.Target != null)
        {
            if (_ManaManager.Mana >= SkillCost)
            {
                _ManaManager.Mana -= SkillCost;
                _ManaManager.ManaTextChange();
                _attakManager.Attak();
            }
            else
            {
                
            }
        }
    }
    
}
