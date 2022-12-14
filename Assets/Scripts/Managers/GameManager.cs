using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Max_Y;
    public float Max_X;
    public Object EnemyPrefab;
    void Start()
    {
        for(int i=0;i<1000;i++)
        {
            Object.Instantiate(EnemyPrefab,new Vector3(Random.Range(-Max_X,Max_X),Random.Range(-Max_X,Max_X),0),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
