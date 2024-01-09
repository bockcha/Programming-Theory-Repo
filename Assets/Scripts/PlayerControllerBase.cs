using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for INHERITANCE
public class PlayerControllerBase : MonoBehaviour
{
    private float vertInput;
    private float horizInput;

    [SerializeField] float driveSpeed;
    [SerializeField] float turnSpeed;

    void Update()
    {
        Move();
    }

    //ABSTRACTION
    private void Move()
    {
        vertInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * vertInput * driveSpeed);

        horizInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * Time.deltaTime * horizInput * turnSpeed);
    }
}
