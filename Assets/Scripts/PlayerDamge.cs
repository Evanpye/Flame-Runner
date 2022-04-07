using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamge : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Rain")
        {
            Debug.Log("LOSS");
            Destroy(collision.transform.gameObject);
            Destroy(this.gameObject);
        }
    }
}
