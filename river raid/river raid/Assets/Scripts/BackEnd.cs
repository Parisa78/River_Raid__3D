using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag(TagNames.enemy.ToString()))
        {
            Debug.Log("heeere");
            Debug.Log(" dead end");
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag(TagNames.fuel.ToString()))
        {
            Debug.Log("back end fuel");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag(TagNames.heart.ToString()))
        {
            Debug.Log("back end heart");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag(TagNames.Hbullet.ToString()))
        {
            Debug.Log("back end heart");
            Destroy(collision.gameObject);
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.CompareTag(TagNames.enemy.ToString()))
    //    {
    //        Debug.Log("heeere");
    //        Debug.Log(" dead end");
    //        Destroy(collision.gameObject);
    //    }

    //}
}
