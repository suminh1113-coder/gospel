using UnityEngine;

public class AttakManager : MonoBehaviour
{
    public GameObject Target;
    public TargetSet _TargetSet;
    [SerializeField] private enemy _enemy;
    public void Attak()
    {
        _enemy = Target.GetComponent<enemy>();
        _enemy.HP -= Random.Range(1, 5);
        _enemy.HP_change();
    }

    public void TargetOff()
    {
        _TargetSet.Off();
    }
    
}
