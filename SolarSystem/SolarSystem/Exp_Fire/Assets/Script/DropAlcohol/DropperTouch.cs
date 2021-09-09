using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropperTouch : MonoBehaviour
{
    public GameObject Dropper, Alcohol, DropperB;

    int count = 0;

    private void Start()
    {
        Dropper = GameObject.Find("Dropper");
        Alcohol = GameObject.Find("Alcohol");
        Alcohol.SetActive(false);
        DropperB = GameObject.Find("DropperB");
        Vector3 vec = Dropper.transform.localPosition;

    }

    private void Update()
    {
        Vector3 vec = Dropper.transform.localPosition;
        DropperB.transform.position = vec + new Vector3(64, 152, 3);


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "DropperB")
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

        if(count == 3)
        {
            SceneManager.LoadScene("DropRegent");
        }

    }

}
