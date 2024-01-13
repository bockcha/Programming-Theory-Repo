using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for INHERITANCE
public class PlayerControllerBase : MonoBehaviour
{
    protected float vertInput;
    protected float horizInput;

    //ENCAPSULATION
    private float driveSpeed = 30.0f;
    [SerializeField] protected float DriveSpeed
    {
        get { return driveSpeed; }
        set
        {
            if(value > 0)
            {
                driveSpeed = value;
            } else
            {
                Debug.LogError("Drive speed cannot be a negative value");
            }
        }
    }
    [SerializeField] protected float turnSpeed;

    [SerializeField] protected GameManager gameManager;

    void Update()
    {
        Move();
    }

    //ABSTRACTION
    protected virtual void Move()
    {
        vertInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * vertInput * DriveSpeed);

        horizInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * Time.deltaTime * horizInput * turnSpeed);
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fail"))
        {
            Destroy(gameObject);
            gameManager.Fail();
            //lose level
        }
        if (other.gameObject.CompareTag("Score"))
        {
            Destroy(gameObject);
            gameManager.Score();
            //win level
        }
    }
}
