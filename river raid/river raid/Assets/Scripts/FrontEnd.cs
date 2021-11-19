using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag(TagNames.bullet.ToString()))
        {
            Debug.Log("heeere");
            Debug.Log(" dead end");
            Destroy(collision.gameObject);

        }

    }
}
