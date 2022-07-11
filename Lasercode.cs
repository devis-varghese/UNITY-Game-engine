using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float _speed= 20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*_speed*Time.deltaTime);
        if(transform.position.y>8f)
        {
            Destroy(this.gameObject);
        }
    }
}
