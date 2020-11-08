using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class fruits_tester : MonoBehaviour {
    // int k = 0;
    public float timeToFill = 1.0f;
    public GameObject[] fruits;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        System.Random rnd = new System.Random();
        int index = rnd.Next(0, 10);
        Debug.Log(index);
        fruits[index].SetActive(true);
        Debug.Log("появился фрукт1");
        fruits[index].transform.RotateAround(Vector3.up, Time.deltaTime);
        fruits[index].SetActive(false);
        Debug.Log("исчез фрукт1");

        index = rnd.Next(0, 10);
        Debug.Log(index);
        fruits[index].SetActive(true);
        Debug.Log("появился фрукт2");
        fruits[index].transform.RotateAround(Vector3.up, Time.deltaTime);
        fruits[index].SetActive(false);
        Debug.Log("исчез фрукт2");

        index = rnd.Next(0, 10);
        Debug.Log(index);
        fruits[index].SetActive(true);
        Debug.Log("появился фрукт3");
        fruits[index].transform.RotateAround(Vector3.up, Time.deltaTime);
        fruits[index].SetActive(false);
        Debug.Log("исчез фрукт3");

        index = rnd.Next(0, 10);
        Debug.Log(index);
        fruits[index].SetActive(true);
        Debug.Log("появился фрукт4");
        fruits[index].transform.RotateAround(Vector3.up, Time.deltaTime);
        fruits[index].SetActive(false);
        Debug.Log("исчез фрукт4");

        index = rnd.Next(0, 10);
        Debug.Log(index);
        fruits[index].SetActive(true);
        Debug.Log("появился фрукт5");
        fruits[index].transform.RotateAround(Vector3.up, Time.deltaTime);
        fruits[index].SetActive(false);
        Debug.Log("исчез фрукт5");

        index = rnd.Next(0, 10);
        Debug.Log(index);
        fruits[index].SetActive(true);
        Debug.Log("появился фрукт6");
        fruits[index].transform.RotateAround(Vector3.up, Time.deltaTime);
        fruits[index].SetActive(false);
        Debug.Log("исчез фрукт6");
        //    if (k<10)
        //{
        //    StartCoroutine("OnDoneAnimation");
        //    k++;
        //}


        fruits[0].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[1].transform.RotateAround (Vector3.up, -Time.deltaTime);
		fruits[2].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[3].transform.RotateAround (Vector3.up, -Time.deltaTime);
		fruits[4].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[5].transform.RotateAround (Vector3.up, -Time.deltaTime);
		fruits[6].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[7].transform.RotateAround (Vector3.up, -Time.deltaTime);
		fruits[8].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[9].transform.RotateAround (Vector3.up, -Time.deltaTime);
	
	}
    IEnumerator OnDoneAnimation()
    {
        float startTime = Time.time;
        float overTime = startTime + timeToFill;

        while (Time.time < overTime) {
            yield return null;
        }

            // yield return new WaitForSeconds(10);
        System.Random rnd = new System.Random();
        int index = rnd.Next(0, 10);
        Debug.Log(index);
        fruits[index].SetActive(true);
        Debug.Log("появился фрукт");
        fruits[index].transform.RotateAround(Vector3.up, Time.deltaTime);
        fruits[index].SetActive(false);
        Debug.Log("исчез фрукт");
    }
}
