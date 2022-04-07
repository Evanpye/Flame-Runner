using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50f;
    float horizontalInput = 0;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(horizontalInput, 0f, 0f);
    }
}
