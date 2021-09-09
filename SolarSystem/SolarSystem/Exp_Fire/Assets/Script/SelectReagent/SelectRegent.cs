using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectRegent : MonoBehaviour
{
    
    public Button btn_K;

    void Start()
    {
        btn_K = this.transform.GetComponent<Button>();
        btn_K.onClick.AddListener(kClick);
    }
    public void kClick()
    {
        Debug.Log("k is clicked");
    }
    
    void Update()
    {

    }
}
