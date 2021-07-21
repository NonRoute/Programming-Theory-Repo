using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : vehicle
{

    // Start is called before the first frame update
    void Start()
    {
        myname = "boat";
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void MyName()
    {
        Debug.Log(myname);
    }
}
