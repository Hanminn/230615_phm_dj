using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy 
{
    private string name;
    private int hp;             

    public Enemy(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }

    public void GetEnemyInfo(){
        UntiyEngine.Debug.Log($"name : {this.name} attack: {this.hp)");
    }

}
