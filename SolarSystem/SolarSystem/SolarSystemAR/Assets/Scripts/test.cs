using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject box1;
    // Start is called before the first frame update
    void Start()
    {
        box1 = GameObject.Find("Box1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Box1")
        {
            Debug.Log("Collided with Box1");
        }
    }
}
