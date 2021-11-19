using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0f, 1f)] public float moveAmount;
    public enemyConfig config;
    void Start()
    {
        
    }

    // Update is called once per frames
    void Update()
    {
        transform.position += new Vector3(0, 0, -moveAmount);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag(TagNames.EndBack.ToString()))
        {
            Debug.Log(" dead end");
            Destroy(collision.gameObject);

        }

    }
}
