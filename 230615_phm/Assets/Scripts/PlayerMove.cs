using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;

    int step = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (step == 1)
        {
            if(player.transform.position <= 2)
                player.transform.position -= new Vector(3 * Time.deltaTime, 0, 0);

        }
        else  
        {
            player.transform.position += new Vector(3 * Time.deltaTime, 0, 0);

        }
        else if(step == 2)
        {
            if(!player.transform.position.x >= 2)

        }
    }
    public void LeftMove()
    {
        step = 1;

    }


    public void RightMove()
    {
        step = 2;
    }
}



