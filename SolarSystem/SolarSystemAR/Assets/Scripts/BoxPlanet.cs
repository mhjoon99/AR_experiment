using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPlanet : MonoBehaviour
{
    public GameObject box1, box2, box3, box4, box5, box6, box7, box8;
    // Start is called before the first frame update
    void Start()
    {
        box1 = GameObject.Find("Box1");
        box2 = GameObject.Find("Box2");
        box3 = GameObject.Find("Box3");
        box4 = GameObject.Find("Box4");
        box5 = GameObject.Find("Box5");
        box6 = GameObject.Find("Box6");
        box7 = GameObject.Find("Box7");
        box8 = GameObject.Find("Box8");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Box1")
        {
            transform.position = new Vector3(-21, -4, 15);
        }
        else if (other.gameObject.name == "Box2")
        {
            transform.position = new Vector3(-15, -4, 15);
        }
        else if (other.gameObject.name == "Box3")
        {
            transform.position = new Vector3(-9, -4, 15);
        }
        else if (other.gameObject.name == "Box4")
        {
            transform.position = new Vector3(-3, -4, 15);
        }
        else if (other.gameObject.name == "Box5")
        {
            transform.position = new Vector3(3, -4, 15);
        }
        else if (other.gameObject.name == "Box6")
        {
            transform.position = new Vector3(9, -4, 15);
        }
        else if (other.gameObject.name == "Box7")
        {
            transform.position = new Vector3(15, -4, 15);
        }
        else if (other.gameObject.name == "Box8")
        {
            transform.position = new Vector3(21, -4, 15);
        }
    }
}
