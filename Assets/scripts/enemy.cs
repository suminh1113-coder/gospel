using UnityEngine;
using UnityEngine.UI;
public class enemy : MonoBehaviour
{
    public int MaxHP = 20;
    public int HP = 20;
    [SerializeField] private Image HPbar;
    private RectTransform _RectTransform;

    void Start()
    {
        _RectTransform = HPbar.GetComponent<RectTransform>();
    }

    public void HP_change()
    {
        if (((float)HP / (float)MaxHP) <= 0)
        {
            _RectTransform.localScale =new Vector3(0, 1f, 1f);
        }
        else
        {
            _RectTransform.localScale =new Vector3((float)HP / (float)MaxHP, 1f, 1f);
        }
    }
}
