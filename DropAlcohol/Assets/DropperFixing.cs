using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    public GameObject Dropper = GameObject.Find("Dropper");

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("충돌");
        Dropper.transform.position = new Vector3(-300, 182, -1054);
    }

}