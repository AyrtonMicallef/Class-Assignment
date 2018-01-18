using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
    public float speed = 1;
    public float boundY = 2.25f;

    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * Time.deltaTime * speed,0 );

        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * Time.deltaTime * speed, 0);

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }       
 }


