using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 offset1;
    public Vector3 offset2;
    public Vector3 offset3;
    
    void Start()
    {
        Instantiate(enemy, offset1,  Quaternion.identity);
        Instantiate(enemy, offset2,  Quaternion.identity);
        Instantiate(enemy, offset3,  Quaternion.identity);
    }
}
