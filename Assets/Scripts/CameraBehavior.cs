using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    private Vector3 offsetPos = new Vector3(0, 6.5f, -10.75f);

    public GameObject player;

    public bool isGameHard;

    private void Start()
    {
        isGameHard = false;
        CheckCameraFocus();
    }

    //ABSTRACTION
    void CheckCameraFocus()
    {
        if (!isGameHard)
        {
            player = GameObject.Find("Car");
        }
        else
        {
            player = GameObject.Find("Plane");
        }
    }

    void LateUpdate()
    {
        transform.position = (player.transform.position + offsetPos);
    }
}
