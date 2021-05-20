using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperTouch : MonoBehaviour
{ 
    public GameObject Dropper = GameObject.Find("Dropper");
    public GameObject Alcohol = GameObject.Find("Alcohol");
    public GameObject Dropper2 = GameObject.Find("Dropper2");
    int count = 0;

    
    
    private void Start()
    {
        Vector3 vec = Dropper.transform.localPosition;

    }

    private void Update()
    {
        Vector3 vec = Dropper.transform.localPosition;
        Dropper2.transform.position = vec + new Vector3(64, 152, 3);


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "Dropper2")
                {
                    Debug.Log("터치");
                    Alcohol.SetActive(true);
                    Alcohol.transform.position = vec + new Vector3(-69, -166, 0);
                }
            }
            /*
            Debug.Log("터치");
            Alcohol.SetActive(true);
            Alcohol.transform.position = vec + new Vector3(-69, -166, 0);*/
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        count++;
        Debug.Log(count+"방울");
        Alcohol.SetActive(false);

    }

}
