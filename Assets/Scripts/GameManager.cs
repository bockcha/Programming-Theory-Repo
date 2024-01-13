using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int failCounter;

    [SerializeField] TextMeshProUGUI failText;

    private void Awake()
    {
        failCounter = 0;
    }

    //ABSTRACTION
    public void Fail()
    {
        failCounter++;
        failText.text = "Fails: " + failCounter;
    }
}
