using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root_Script : MonoBehaviour
{

    int rootLevel = 0;


    public Sprite Roots_0;
    public Sprite Roots_1;
    public Sprite Roots_2;


    void Update()
    {
        CheckUpgrade();
    }



    void CheckUpgrade()
    {
        if (rootLevel == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Roots_0;
        }
        else if (rootLevel == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Roots_1;
        }
        else if (rootLevel == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Roots_2;
        }

    }
}
