using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Base class for INHERITANCE
public class OscillatingBase : MonoBehaviour
{
    private float time;
    [SerializeField] float speed = 1;

    private int length = 1;

    [SerializeField] Vector3 pointA;
    [SerializeField] Vector3 pointB;

    private void Start()
    {
        SetOscillationPos();
    }
    void Update()
    {
        Oscillate();
    }

    //ABSTRACTION
    void Oscillate()
    {
        time = Mathf.PingPong(Time.time * speed, length);

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
