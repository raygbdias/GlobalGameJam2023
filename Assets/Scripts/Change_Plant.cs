using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Plant : MonoBehaviour
{
     Sprite Plant_Level_1_3;
     Sprite Plant_Level_1_2;
     Sprite Plant_Level_1_1;
     Sprite Plant_Level_1_0;

     Sprite Plant_Level_2_3;
     Sprite Plant_Level_2_2;
     Sprite Plant_Level_2_1;
     Sprite Plant_Level_2_0;

    bool hasSpike;
    bool hasflower;
    int plantLevel;

    void Start() {
       
        hasflower = true;
        hasSpike = true;
        plantLevel = 1;
    }

    void Update()
    {

        if (hasSpike && hasflower && (plantLevel == 1))
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

    }
}
