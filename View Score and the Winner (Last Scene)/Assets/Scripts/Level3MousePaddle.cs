using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3MousePaddle : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 13f) - 8.5f;
        Debug.Log(mousePosInUnits);

        //this.transfrom.position.y: keeps the starting y-value
        Vector3 paddlePosition = new Vector3(-8.65f, this.transform.position.x, 0f);

        //make the paddle move with the mouse
        paddlePosition.y = Mathf.Clamp(mousePosInUnits, -3.68f, 3.75f);

        //set the position of the paddle (this) to paddlePosition
        this.transform.position = paddlePosition;
    }
}
