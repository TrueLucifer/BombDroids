﻿using UnityEngine;
using System.Collections;

public class LogController10 : MonoBehaviour {



    public float Timer = .5f;

    public GameObject[] Logs10;

    // Update is called once per frame
    void Update()
    {
        TimeS();
        LogSpawner();
        // LogDirection();
    }

    void TimeS()
    {
        if (GameVariables.LogSpawn10 == false)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            if (GameVariables.LogSpawn10 == true)
            {
                Timer = 0.5f;
            }

        }
    }


    void LogSpawner()
    {


        if (Timer <= 0)
        {
            Instantiate(Logs10[Random.Range(0, Logs10.Length)], transform.position, transform.rotation);


            /*
            Instantiate(ls, transform.position + (transform.forward * 2), transform.rotation);
			*/

            GameVariables.LogSpawn10 = true;
        }
    }
}
