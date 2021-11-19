using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPlacer : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject[] comboPrefabs;
    
    public float minX;
    public float maxX;
    // Start is called before the first frame update
    public float timerMaxTime;
    private float currentTimerValue;
    private int index;

    private void Start()
    {
        currentTimerValue = timerMaxTime;
    }

    void FixedUpdate()
    {
        if (currentTimerValue > 0)
        {
            currentTimerValue -= Time.deltaTime;
        }
        else
        {
            GameObject go;

            if (UnityEngine.Random.Range(0, 2000) % 2 == 0)
            {
                index = GetRandomPrefabType(comboPrefabs.Length);
                go = Instantiate(comboPrefabs[index]);
            }
            else
            {
                go = Instantiate(prefabs[GetRandomPrefabType(prefabs.Length)]);
            }

            go.transform.position = new Vector3(GetRandomPrefabInitialX(), transform.position.y, transform.position.z);
            UpdateTimerValueBasedOnScore();

            // reset timer
            currentTimerValue = timerMaxTime;
        }
    }

    private void UpdateTimerValueBasedOnScore()
    {
        if (FindObjectOfType<UiManager>().score % 10000 < 100 && FindObjectOfType<UiManager>().score > 0)
        {
            timerMaxTime -= 0.03f;

            if (timerMaxTime < 0.5f)
                timerMaxTime = 0.5f;
        }

    }

    int GetRandomPrefabType(int max)
    {
        return UnityEngine.Random.Range(0, max);
    }

    float GetRandomPrefabInitialX()
    {
        return UnityEngine.Random.Range(minX, maxX);
    }
}
