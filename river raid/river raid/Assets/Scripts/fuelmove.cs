using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelmove : MonoBehaviour
{
    [Range(0f, 1f)] public float moveAmount;
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

        if (collision.gameObject.CompareTag(TagNames.bullet.ToString()))
        {
            Debug.Log(" hit bullet ");
            Destroy(collision.gameObject);

        }

    }
}
