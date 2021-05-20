using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Alcohol = GameObject.Find("Alcohol");

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
        Alcohol.SetActive(false);

    }
}
