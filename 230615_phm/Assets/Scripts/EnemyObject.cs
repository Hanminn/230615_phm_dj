using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyObject : MonoBehaviour
{
    [SerializeField] private Sprite[] enemyImg;

    Ememy enemy;

    public void SetEnemy(Enemy e)
    {
        this.enemy = e;
    }


    private void Update()
    {
        MoveEnemy();

    }

    private void MoveEnemy()
    {
        if (this.transform.position.y <= -2) return;

        this.transform.position -= new Vector3(0, 3 * Time.deltaTime, 0);

    }
}