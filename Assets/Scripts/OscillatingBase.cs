using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Base class for INHERITANCE
public class OscillatingBase : MonoBehaviour
{
    protected float time;
    [SerializeField] protected float speed = 0.6f;
    [SerializeField] protected float delayTime;


    protected int length = 1;

    [SerializeField] protected Vector3 pointA;
    [SerializeField] protected Vector3 pointB;

    private void Start()
    {
        SetOscillationPos();
    }
    void Update()
    {
        Oscillate();
    }

    //ABSTRACTION and POLYMORPHISM
    protected virtual void Oscillate()
    {
        time = Mathf.PingPong((Time.time+delayTime) * speed, length);

        transform.position = Vector3.Lerp(pointA, pointB, time);
    }

    //ABSTRACTION
    void SetOscillationPos()
    {
        pointA.z = transform.position.z;
        pointB.z = transform.position.z;
        pointA.y = transform.position.y;
        pointB.y = transform.position.y;
    }
}
