using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

//INHERITANCE
public class OscillatingRotating : OscillatingBase
{
    [SerializeField] float rotSpeed;
    
    void Update()
    {
        Oscillate();
    }

    //ABSTRACTION
    void Spin()
    {
        transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
    }

    //ABSTRACTION and POLYMORPHISM
    protected override void Oscillate()
    {
        time = Mathf.PingPong((Time.time+delayTime) * speed, length);

        transform.position = Vector3.Lerp(pointA, pointB, time);

        Spin();
    }
}
