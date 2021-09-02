using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player1, Player2;
    private float speed = 13.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInputPlayer1, horizontalInputPlayer2;
    private float forwardInputPlayer1, forwardInputPlayer2;
   

    // Update is called once per frame
    void Update()
    {
        //this is where we get player input
        horizontalInputPlayer1 = Input.GetAxis("Horizontal");
        forwardInputPlayer1 = Input.GetAxis("Vertical");

        horizontalInputPlayer2 = Input.GetAxis("Horizontal2");
        forwardInputPlayer2 = Input.GetAxis("Vertical2");

        // we  move the player1 and player2 forward
        Player1.transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInputPlayer1);
        Player2.transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInputPlayer2);

        // backword translation player1
        if (forwardInputPlayer1 < 0) Player1.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * (-horizontalInputPlayer1));
        else Player1.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInputPlayer1);

        // backword translation player2
        if (forwardInputPlayer2 < 0) Player2.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * (-horizontalInputPlayer2));
        else Player2.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInputPlayer2);

    }
}
