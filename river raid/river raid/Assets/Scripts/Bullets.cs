using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [Range(0f, 1f)] public float moveAmount;
    private playerController player;
    // Start is called before the first frame update
    private int score;
    void Start()
    {
        score = 0;
        player = FindObjectOfType<playerController>();
        transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, moveAmount);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagNames.enemy.ToString()))
        {
            Debug.Log("shoot");
            enemyConfig enemy_conf = collision.gameObject.GetComponent<moveEnemy>().config;
            score += enemy_conf.score;
            Debug.Log("score"+ score);
            Destroy(collision.gameObject);
            
        }
    }

}
