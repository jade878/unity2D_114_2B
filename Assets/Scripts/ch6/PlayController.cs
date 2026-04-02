using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    Rigidbody2D cat;
    float jumpForce = 680.0f;
    float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        cat = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cat.AddForce(transform.up * jumpForce);
        }
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        float speedx=Mathf.Abs(cat.velocity.x);
        if (speedx < maxWalkSpeed)
        {
            cat.AddForce(transform.right * key * 10.0f);
        }
        if (key != 0) { 
            transform.localScale = new Vector3(key,1,1);
        }

    }
}
