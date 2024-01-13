using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI failText;

    [SerializeField] GameObject car;
    [SerializeField] GameObject plane;

    [SerializeField] GameObject failState;
    [SerializeField] GameObject scoreState;

    private void Awake()
    {
        failText.text = "Fails: " + MainManager.Instance.FailCounter;
        SetGameObject();
    }

    private void SetGameObject()
    {
        if (!MainManager.Instance.isGameHard)
        {
            car.gameObject.SetActive(true);
            plane.gameObject.SetActive(false);
        }
        else
        {
            car.gameObject.SetActive(false);
            plane.gameObject.SetActive(true);
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    //ABSTRACTION
    public void Fail()
    {
        MainManager.Instance.FailCounter++;
        failText.text = "Fails: " + MainManager.Instance.FailCounter;
        failState.SetActive(true);
    }

    public void Score()
    {
        scoreState.SetActive(true);
        if (MainManager.Instance.FailCounter < MainManager.Instance.FailLow)
        {
            MainManager.Instance.FailLow = MainManager.Instance.FailCounter;
        } 
    }
}
