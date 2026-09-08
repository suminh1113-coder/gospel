using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        Instantiate(enemy, new Vector3(6, 0, 1),  Quaternion.identity);
        Instantiate(enemy, new Vector3(4, 3.5f, 1),  Quaternion.identity);
        Instantiate(enemy, new Vector3(4, -3.5f, 1),  Quaternion.identity);
    }
}
