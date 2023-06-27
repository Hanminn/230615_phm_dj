using System;

public class Enemy1 {

    public enum EnemyType {
        Basic = 0,
        Range,
    }

    private EnemyType enemyType;
    private int atk;
    private float speed;
    private int hp;

    public Enemy1(EnemyType type, int hp, int atk, float speed) {
        this.enemyType = type;
        this.hp = hp;
        this.atk = atk;
        this.speed = speed;
    }

    public int Hp
    {
        get { return this.hp; }
    }
    public int Atk
    {
        get { return this.atk; }
    }
    public float Speed
    {
        get { return this.speed; }
    }


    public bool Hit(int dmg){  //Á×¾ú³Ä ¾ÈÁ×¾ú³Ä È®ÀÎ 
        if (this.hp - dmg <= 0) return false;

        this.hp -= dmg;

        return true;
    }

    

}
