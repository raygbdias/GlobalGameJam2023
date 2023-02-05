using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Plant : MonoBehaviour
{
    public Sprite Plant_Level_1_3;
    public Sprite Plant_Level_1_2;
    public Sprite Plant_Level_1_1;
    public Sprite Plant_Level_1_0;

    public Sprite Plant_Level_2_3;
    public Sprite Plant_Level_2_2;
    public Sprite Plant_Level_2_1;
    public Sprite Plant_Level_2_0;

    public Sprite Plant_Level_3_3;
    public Sprite Plant_Level_3_2;
    public Sprite Plant_Level_3_1;
    public Sprite Plant_Level_3_0;

    public bool hasSpike = true;
    public bool hasflower = true;
    public int plantLevel = 1;


    void Update() {

        if (hasSpike && hasflower && plantLevel == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_1_3;
        }
        else if (!hasSpike && hasflower && (plantLevel == 1))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_1_1;
        }
        else if (hasSpike && !hasflower && (plantLevel == 1))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_1_2;
        }
        else if (!hasflower && !hasSpike && (plantLevel == 1))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_1_0;
        }
        else if (!hasSpike && hasflower && (plantLevel == 2))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_2_1;
        }
        else if (hasSpike && !hasflower && (plantLevel == 2))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_2_2;
        }
        else if (!hasflower && !hasSpike && (plantLevel == 2))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_2_0;
        }
        else if (hasflower && hasSpike && (plantLevel == 2))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_2_3;
        }

        else if (!hasSpike && hasflower && (plantLevel == 3))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_3_1;
        }
        else if (hasSpike && !hasflower && (plantLevel == 3))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_3_2;
        }
        else if (!hasflower && !hasSpike && (plantLevel == 3))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_3_0;
        }
        else if (hasflower && hasSpike && (plantLevel == 3))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Plant_Level_3_3;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            plantLevel++;

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            plantLevel--;

        }

    }
}

    

