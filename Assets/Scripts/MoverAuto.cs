using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAuto : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 20;
    float inputY;
    float inputX;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputY = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime*speed*inputX);
        transform.Translate(Vector3.forward*Time.deltaTime*speed*inputY);
    }
}
