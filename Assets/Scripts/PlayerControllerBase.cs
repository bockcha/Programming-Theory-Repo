using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for INHERITANCE
public class PlayerControllerBase : MonoBehaviour
{
    protected float vertInput;
    protected float horizInput;

    [SerializeField] protected float driveSpeed;
    [SerializeField] protected float turnSpeed;

    void Update()
    {
        Move();
    }

    //ABSTRACTION
    protected virtual void Move()
    {
        vertInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * vertInput * driveSpeed);

        horizInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * Time.deltaTime * horizInput * turnSpeed);
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fail"))
        {
            Destroy(gameObject);
            //lose level
        }
        if (other.gameObject.CompareTag("Score"))
        {
            //win level
        }
    }
}
