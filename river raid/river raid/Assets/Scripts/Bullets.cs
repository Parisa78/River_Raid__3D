using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [Range(0f, 1f)] public float moveAmount;
    private playerController player;
    private UiManager uimanager;
    // Start is called before the first frame update

    void Start()
    {
        player = FindObjectOfType<playerController>();
        uimanager = FindObjectOfType<UiManager>();
        transform.position = player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, moveAmount);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagNames.enemy.ToString()))
        {
            Debug.Log("shoot");
            enemyConfig enemy_conf = collision.gameObject.GetComponent<moveEnemy>().config;
            uimanager.ScoreCount(enemy_conf.score);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag(TagNames.fuel.ToString()))
        {
            Debug.Log("fuel");
            uimanager.FuelCount(10);
            Destroy(collision.gameObject);
        }
    }

}
