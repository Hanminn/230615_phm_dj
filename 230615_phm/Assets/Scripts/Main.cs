using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    int a;
    int[] arrayNumber = new int[10];

    Enemy[] enemyList = new Enemy[10];

    List<int> listNunber = new List<int>();

    List<Enemy> eList = new List<Enemy>();

    
    // Start is called before the first frame update
    void Start()
    {
        


        for (int i = ; i < enemyList.Length; i++)
        {
            Enemy e = new Enemy("elf", i);
            e.GetEnemyInfo();

            eList.Add(e);
        }
        

        Enemy e1 = new Enemy("elf", 10);
        Enemy e2 = new Enemy("dragon", 100);



        e1.GetEnemyInfo();
        e2.GetEnemyInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
