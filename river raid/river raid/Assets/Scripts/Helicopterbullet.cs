using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopterbullet : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0f, 1f)] public float moveAmount;
    public float timerMaxTime;
    private float currentTimerValue;
    public GameObject bullet;
    void Start()
    {
        currentTimerValue = timerMaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimerValue > 0)
        {
            currentTimerValue -= Time.deltaTime;
        }
        else
        {
            bullet.transform.position = new Vector3(transform.position.x+ (float) 5, transform.position.y + (float)3, transform.position.z);
            Instantiate(bullet);
            bullet.transform.position += new Vector3(0, 0, -moveAmount);
            currentTimerValue = timerMaxTime;
        }
        
    }
}
