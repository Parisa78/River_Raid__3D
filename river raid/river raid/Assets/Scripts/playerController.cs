using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [Range(0f, 1f)] public float moveAmount;

    private bool roof;
    private bool ground;
    private bool left_wall;
    private bool right_wall;
    public Rigidbody rb;


    public float timerMaxTime;
    private float currentTimerValue;
    private UiManager uimanager;

    public GameObject bullets;
    // Start is called before the first frame update
    void Start()
    {
        roof=true;
        ground = true;
        left_wall = true;
        right_wall = true;
        currentTimerValue = timerMaxTime;
        uimanager = FindObjectOfType<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTimerValue > 0)
        {
            currentTimerValue -= Time.deltaTime;
        }
        else
        {
            uimanager.FuelCount(-5);
            currentTimerValue = timerMaxTime;
        }

        if (Input.GetKey(KeyCode.D) && right_wall)
        {
            transform.position += new Vector3(moveAmount, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) && left_wall)
        {
            transform.position += new Vector3(-moveAmount, 0, 0);
        }

        if (Input.GetKey(KeyCode.W) && roof)
        {
            transform.position += new Vector3(0, moveAmount, 0);
        }

        if (Input.GetKey(KeyCode.S) && ground)
        {
            transform.position += new Vector3(0, -moveAmount, 0);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(bullets);
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag(TagNames.leftWall.ToString()))
        {
            Debug.Log("left waalll");
            left_wall = false;

        }

        if (collision.gameObject.CompareTag(TagNames.rightWall.ToString()))
        {
            Debug.Log("rigght waalll");
            right_wall = false;
        }

        if (collision.gameObject.CompareTag(TagNames.roof.ToString()))
        {
            roof = false;
        }

        if (collision.gameObject.CompareTag(TagNames.ground.ToString()))
        {
            Debug.Log("groound");
            ground = false;
        }

        if (collision.gameObject.CompareTag(TagNames.fuel.ToString()))
        {
            Debug.Log("fuel");
            uimanager.FuelCount(10);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag(TagNames.heart.ToString()))
        {
            Debug.Log("heeeaart");
            uimanager.UpdateHeartCountText(1);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag(TagNames.enemy.ToString()))
        {
            Debug.Log("heeeaart");
            uimanager.UpdateHeartCountText(-1);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag(TagNames.Hbullet.ToString()))
        {
            uimanager.UpdateHeartCountText(-1);
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagNames.leftWall.ToString()))
        {
            Debug.Log("left waalll");
            left_wall = true;

        }

        if (collision.gameObject.CompareTag(TagNames.rightWall.ToString()))
        {
            right_wall = true;
        }

        if (collision.gameObject.CompareTag(TagNames.roof.ToString()))
        {
            roof = true;
        }

        if (collision.gameObject.CompareTag(TagNames.ground.ToString()))
        {
            ground = true;
        }
    }
}
