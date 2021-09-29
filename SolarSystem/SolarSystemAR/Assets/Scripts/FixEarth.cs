using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixEarth : MonoBehaviour
{
    public GameObject box1, box2, box3, box4, box5, box6, box7, box8;
    public int ansEarth;
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
        //transform.position = new Vector3(-21, -4, 10);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Box1")
        {
            Debug.Log("Collided with Box1");
            ansEarth = 0;
        }
        else if (collider.gameObject.name == "Box2")
        {
            Debug.Log("Collided with Box2");
            ansEarth = 0;
        }
        else if (collider.gameObject.name == "Box3")
        {
            Debug.Log("Collided with Box3");
            ansEarth = 1;
        }
        else if (collider.gameObject.name == "Box4")
        {
            Debug.Log("Collided with Box4");
            ansEarth = 0;
        }
        else if (collider.gameObject.name == "Box5")
        {
            Debug.Log("Collided with Box5");
            ansEarth = 0;
        }
        else if (collider.gameObject.name == "Box6")
        {
            Debug.Log("Collided with Box6");
            ansEarth = 0;
        }
        else if (collider.gameObject.name == "Box7")
        {
            Debug.Log("Collided with Box7");
            ansEarth = 0;
        }
        else if (collider.gameObject.name == "Box8")
        {
            Debug.Log("Collided with Box8");
            ansEarth = 0;
        }
    }
    public int GetEarth()
    {
        return ansEarth;
    }
}
