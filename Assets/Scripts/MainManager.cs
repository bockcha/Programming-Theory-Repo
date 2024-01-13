using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }

    public bool isGameHard;

    //ENCAPSULATION
    private int failLow = 100;
    public int FailLow
    {
        get { return failLow; } 
        set { 
            if (value >= 0) {
                failLow = value;
            } else
            {
                Debug.LogError("Highscore cannot be a negative value");
            }
        }
    }

    private int failCounter;
    public int FailCounter
    {
        get { return failCounter; }
        set
        {
            if (value >= 0)
            {
                failCounter = value;
            }
            else
            {
                Debug.LogError("Counter cannot be a negative value");
            }
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
