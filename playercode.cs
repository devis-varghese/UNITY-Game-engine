using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class player : MonoBehaviour
    {
//[SerializeField]
public float _speed = 3.5f;
//[SerializeField]
public GameObject _laserPrefab;
//[SerializeField]
public float _firerate=0.5f;
public float _canfire=-1f;
public float horizontalInput;
public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        //Take the current position = new position(0 ,0 ,0)
        transform.position=new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
       CalculateMovement();
    if(Input.GetKeyDown(KeyCode.Space)&& Time.time > _canfire)
    {
        _canfire=Time.time+_firerate;
        Instantiate(_laserPrefab,transform.position+ new Vector3(0,0.8f,0),Quaternion.identity);
    }



       if(Input.GetKeyDown(KeyCode.Space))
       {
        Instantiate(_laserPrefab,transform.position + new Vector3(0, 0.8f, 0 ),Quaternion.identity);
       }
    }
    void CalculateMovement()
    {
         float horizontalInput=Input.GetAxis("Horizontal");
        float verticalInput=Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime); 
        transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);

        if(transform.position.y >=0 )
        {
            transform.position=new Vector3(transform.position.x, 0, 0);
        
        }
        else if (transform.position.y <= -3.8f)
        {
            transform.position = new Vector3(transform.position.x, -3.8f,0);

        }

        if(transform.position.x > 11.3f)
        {
            transform.position=new Vector3(-11.3f,transform.position.y,0);
        }
        else if(transform.position.x < -11.3f)
        {
           transform.position=new Vector3(11.3f,transform.position.y,0);
        }
    }
}


