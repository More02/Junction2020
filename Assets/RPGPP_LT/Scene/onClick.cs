using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class onClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Я живой");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickk(string msg)
    {
        Debug.Log(msg);
    }
}
