using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

//INHERITANCE
public class PlayerControllerPlane : PlayerControllerBase
{
    void Update()
    {
        Move();
    }

    //POLYMORPHISM
    protected override void Move()
    {
        vertInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.right * Time.deltaTime * vertInput * turnSpeed);

        horizInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * Time.deltaTime * horizInput * turnSpeed);

        transform.Translate(Vector3.forward * Time.deltaTime * driveSpeed);
    }
}
