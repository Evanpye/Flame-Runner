using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainFall : MonoBehaviour
{
    public GameObject rainPrefab;
    private void Start()
    {
        InvokeRepeating("creatRain", 1f, Random.Range(1,5));
    }

    void creatRain()
    {
        Instantiate(rainPrefab,transform.position+new Vector3(Random.Range(-5, 5), 0f,0f),Quaternion.identity);
    }
}
