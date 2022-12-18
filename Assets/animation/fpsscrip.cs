using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsscrip : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        string info = "[p] = play, [b] = play backwards, [s] = stop";
        print(info);

        Anim = GetComponent<Animator>();
        Anim.SetFloat("Dir", 0f);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            print("play");

            Anim.SetFloat("Dir", 1f);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            print("play backwards");

            Anim.SetFloat("Dir", -1f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            print("stop");

            Anim.SetFloat("Dir", 0f);
        }
    }
}
