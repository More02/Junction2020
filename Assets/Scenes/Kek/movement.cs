using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.00001f;
    public GameObject gameObject;
    public GameObject game;
    public Camera camObject;
    public CharacterController character;
    private float distanceToGround;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.rotation = new Quaternion((360 - camObject.transform.localEulerAngles.z)%360, (360 - camObject.transform.localEulerAngles.y) % 360, (360 - camObject.transform.localEulerAngles.x) % 360, camObject.transform.rotation.w);
        //gameObject.transform.rotation = new Quaternion(camObject.transform.rotation.z, camObject.transform.rotation.y, camObject.transform.rotation.x, camObject.transform.rotation.w);
        //gameObject.transform.position = new Vector3(transform.position.x + speed * (float)Math.Cos(camObject.transform.localEulerAngles.x * Math.PI/180),
        //transform.position.y + speed * (float)Math.Cos(camObject.transform.localEulerAngles.y * Math.PI / 180), transform.position.z + speed * (float)Math.Cos(camObject.transform.localEulerAngles.z * Math.PI / 180));
 
        gameObject.transform.Rotate(360 - camObject.transform.localRotation.x, camObject.transform.localRotation.y, 360 - camObject.transform.localRotation.z, Space.Self);
        gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);

        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
            distanceToGround = hit.distance;
        }
        if (Physics.Raycast(transform.position, -Vector3.forward, out hit))
        {
            var distanceToFirst = hit.distance;
            Debug.Log("Keeeeeeek " + distanceToFirst);
            if (distanceToFirst < 0.3)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z+distanceToFirst);
            }
        }

        if (distanceToGround < 0.3)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + distanceToGround, gameObject.transform.position.z);
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("Keeeeeeek " + col.gameObject.name);
        if (col.gameObject.name.Contains("Sphere"))
        {
            Destroy(col.gameObject);
        }
    }
    void OnGUI() { 
        
    }
}
