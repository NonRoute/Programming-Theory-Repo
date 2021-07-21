using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class vehicle : MonoBehaviour
{
    protected string myname {get; set;}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnMouseDown() {
        MyName();
    }

    protected abstract void MyName();
}
