using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI failLow;

    private void Awake()
    {
        failLow.text = "Lowest # Fails: " + MainManager.Instance.FailLow;
    }
    public void EasyClick()
    {
        //easy mode set
        MainManager.Instance.isGameHard = false;
        SceneManager.LoadScene(1);
        MainManager.Instance.FailCounter = 0;
    }

    public void HardClick()
    {
        //hard mode set
        MainManager.Instance.isGameHard = true;
        SceneManager.LoadScene(1);
        MainManager.Instance.FailCounter = 0;
    }
}
