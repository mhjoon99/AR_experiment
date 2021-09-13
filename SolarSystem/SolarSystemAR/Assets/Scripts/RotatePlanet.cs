using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public Transform targetTr;
    private Transform tr; // 무엇을 기준으로 회전할지 결정!!

   public float rotSpeed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.RotateAround(targetTr.position, Vector3.up, Time.deltaTime * rotSpeed);

    }
}  
