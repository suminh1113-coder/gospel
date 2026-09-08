using UnityEngine;

public class Skillbutton : MonoBehaviour
{
    public AttakManager _attakManager;
    public GameObject GameController;
    void Start()
    {
        GameController = GameObject.FindWithTag("GameController");  
        _attakManager = GameController.GetComponent<AttakManager>();
    }
    public void Click()
    {
        _attakManager.Attak();
    }
    
}
