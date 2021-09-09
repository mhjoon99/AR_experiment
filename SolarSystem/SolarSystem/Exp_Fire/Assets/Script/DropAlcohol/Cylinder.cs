using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public GameObject Dropper, Alcohol, Dropper2;
    
    void Start()
    {
        Dropper = GameObject.Find("Dropper");
        Alcohol = GameObject.Find("Alcohol");
        Dropper2 = GameObject.Find("Dropper2");
        //Vector3 vec = Dropper.transform.localPosition;
    }
    /*
    private void Update()
    {
        Vector3 vec = Dropper.transform.localPosition;
        Dropper2.transform.position = vec + new Vector3(64, 152, 3);


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("터치");
            Alcohol.SetActive(true);
            Alcohol.transform.position = vec + new Vector3(-69, -166, 0);
        }

    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
        Dropper.transform.position = new Vector3(-299, 182, -1054);


    }
    /*
    private void OnCollisionStay(Collision collision)
    {
        Dropper.transform.position = new Vector3(-299, 182, -1054);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("터치");
            Alcohol.SetActive(true);
            Alcohol.transform.position = new Vector3(-369, 14, -1054);
        }
    }
    */
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌 끝");
        Dropper.transform.position = new Vector3(-299, 182, -1054);
    }


}
