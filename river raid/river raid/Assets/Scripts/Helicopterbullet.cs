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
        bullet.transform.position = new Vector3(transform.position.x + (float)5, transform.position.y + (float)3, transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentTimerValue > 0)
        {
            currentTimerValue -= Time.deltaTime;
        }
        else
        {
            Instantiate(bullet);
            currentTimerValue = timerMaxTime;
        }
        
    }
}
