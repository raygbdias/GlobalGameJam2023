using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanScrpit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 left = Vector3.left;

        float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = left * timeSinceLastFrame;

        transform.Translate(
            translation
            );

    }
}
