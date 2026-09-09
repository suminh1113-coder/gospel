using UnityEngine;
using UnityEngine.UI;
public class HPscripts : MonoBehaviour
{
    public int MaxHP = 20;
    public int HP = 20;
    [SerializeField] private Image HPbar;
    private RectTransform _RectTransform;
    private GameObject Entity;
    private AttakManager _attakManager;
    private GameObject GameController;

    void OnEnable()
    {
        GameController = GameObject.FindWithTag("Attak_Manager");  
        _attakManager = GameController.GetComponent<AttakManager>();
        _RectTransform = HPbar.GetComponent<RectTransform>();
        Entity = transform.parent.gameObject;
    }

    public void HP_change()
    {
        if (((float)HP / (float)MaxHP) <= 0)
        {
            _attakManager.Target = null;
            Destroy(Entity);
        }
        else
        {
            _RectTransform.localScale =new Vector3((float)HP / (float)MaxHP, 1f, 1f);
        }
    }
}
