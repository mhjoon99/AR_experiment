//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class collisionMercury : MonoBehaviour
//{
//    public GameObject mercury;
//    //venus, earth, mars, jupiter, saturn, uranus, neptune;
//    public GameObject box1, box2, box3, box4, box5, box6, box7, box8;
//    public GameObject messageBox, btnRevolution, btnRotation;

//    // Start is called before the first frame update
//    void Start()
//    {
//        mercury = GameObject.Find("Mercury");
//        //venus = GameObject.Find("Venus");
//        //earth = GameObject.Find("Earth");
//        //mars = GameObject.Find("Mars");
//        //jupiter = GameObject.Find("Jupiter");
//        //saturn = GameObject.Find("Saturn");
//        //uranus = GameObject.Find("Uranus");
//        //neptune = GameObject.Find("Neptune");

//        box1 = GameObject.Find("Box1");
//        box2 = GameObject.Find("Box2");
//        box3 = GameObject.Find("Box3");
//        box4 = GameObject.Find("Box4");
//        box5 = GameObject.Find("Box5");
//        box6 = GameObject.Find("Box6");
//        box7 = GameObject.Find("Box7");
//        box8 = GameObject.Find("Box8");

//        messageBox = GameObject.Find("messageBox");
//        btnRevolution = GameObject.Find("btnRevolution");
//        btnRotation = GameObject.Find("btnRotation");

//        messageBox.SetActive(false);
//        //btnRevolution.SetActive(true);
//        //btnRotation.SetActive(true);
//        btnRevolution.GetComponent<Button>().interactable = true;
//        btnRotation.GetComponent<Button>().interactable = true;

//        //Vector3 vecMercury = mercury.transform.localPosition;
//        //Vector3 vecVenus = venus.transform.localPosition;
//        //Vector3 vecEarth = earth.transform.localPosition;
//        //Vector3 vecMars = mars.transform.localPosition;
//        //Vector3 vecJupiter = jupiter.transform.localPosition;
//        //Vector3 vecSaturn = saturn.transform.localPosition;
//        //Vector3 vecUranus = uranus.transform.localPosition;
//        //Vector3 vecNeptune = neptune.transform.localPosition;
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    public void OnCollisionStay(Collision collision)
//    {
//        int ansMercury;

//        if (collision.gameObject.name == "Box1")
//        {
//            Debug.Log("Collided with Box1!");
//            ansMercury = 1;
//        }
//        //else if (collision.gameObject.name == "Box2")
//        //{
//        //    Debug.Log("Collided with Box2!");
//        //    ansMercury = 2;
//        //}
//    }
//}
