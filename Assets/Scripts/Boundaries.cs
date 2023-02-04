using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public GameObject LeftLimitGameObject;

    private Vector3 LeftLimit;
    // Start is called before the first frame update
    void Start()
    {
        LeftLimit = LeftLimitGameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
