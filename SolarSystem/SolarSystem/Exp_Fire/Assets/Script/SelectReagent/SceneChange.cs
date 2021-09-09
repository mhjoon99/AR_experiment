using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int stageNum;
    public GameObject stageNumObject;

    public void call()
    {
        SceneManager.LoadScene("CombineCottonFoil");
        DontDestroyOnLoad(stageNumObject);
    }
}

    
