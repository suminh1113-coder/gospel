using UnityEngine;

public class AttakManager : MonoBehaviour
{
    public GameObject Target;
    public TargetSet _TargetSet;
    [SerializeField] private HPscripts _enemyHP;
    public void Attak()
    {
        _enemyHP = Target.GetComponent<HPscripts>();
        _enemyHP.HP -= Random.Range(1, 5);
        _enemyHP.HP_change();
    }

    public void TargetOff()
    {
        _TargetSet.Off();
    }
    
}
