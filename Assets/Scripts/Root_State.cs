using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootState : MonoBehaviour
{

    int rootLevel;


    public Sprite Roots_0;
    public Sprite Roots_1;
    public Sprite Roots_2;
    // Start is called before the first frame update
    void Start()
    {
        rootLevel = 0;
    }

    // Update is called once per frame
    void Update()
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

        if (Input.GetKey("up"))
        {
            rootLevel++;
        }
        if (Input.GetKey("down"))
        {
            rootLevel--;
        }

    }
}
