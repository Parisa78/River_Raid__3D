﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
