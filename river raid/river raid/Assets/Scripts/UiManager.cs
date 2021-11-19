using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text counterText;
    public Text fuelText;
    public Text HeartCount;
    public GameObject  GOver;
    //public GameObject Win;

    private void Awake() 
    {
    }

    void Start()
    {

    }


    public void ScoreCount(int amount)
    {
        string[] newText = counterText.text.Split(':');
        int hold = int.Parse(newText[1]) + amount;
        counterText.text = newText[0] + ": " + hold.ToString();
    }

    public void FuelCount(int amount)
    {
        string[] newText = fuelText.text.Split(':');
        int hold = int.Parse(newText[1]) + amount;
        if (hold > 100)
        {
            hold = 100;
        }
        else if (hold <= 0)
        {
            GameOverScene();
        }
        fuelText.text = newText[0] + ": " + hold.ToString();
    }

    public void UpdateHeartCountText(int amount)
    {

        int hold = int.Parse(HeartCount.text) + amount;
        HeartCount.text =  hold.ToString();
        if (hold <= 0)
        {
            GameOverScene();
        }
    }
    public void GameOverScene()
    {
        GOver.SetActive(true);
        FindObjectOfType<playerController>().GetComponent<MonoBehaviour>().enabled = false;
        FindObjectOfType<enemyPlacer>().GetComponent<MonoBehaviour>().enabled = false;
    }

    //public void WiningScene()
    //{
    //    Win.SetActive(true);
    //    FindObjectOfType<PlayerController>().GetComponent<MonoBehaviour>().enabled = false;
    //FindObjectOfType<FoodPlacer>().GetComponent<MonoBehaviour>().enabled = false;
    //}
}
