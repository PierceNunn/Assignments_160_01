using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData;
    // Start is called before the first frame update
    void Start()
    {
        print(enemyData.EnemyName1 + " has " + enemyData.EnemyHealth1 + " health ");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print(enemyData.EnemyName1 + " has " + enemyData.EnemyHealth1 + " health ");
        }
    }
}
