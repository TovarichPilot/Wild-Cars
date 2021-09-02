using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 frontOffset = new Vector3(0, 1.92f, 0.4f);

    public Camera frontCameraPlayer1;
    public Camera frontCameraPlayer2;

    public Camera mainCameraPlayer1;
    public Camera mainCameraPlayer2;

    public int CamModePlayer1 = 0;
    public int CamModePlayer2 = 0;

    // Update is called once per frame
    void LateUpdate()
    {
        // offset the camera behind the player be adding to the player's position 
        mainCameraPlayer1.transform.position = player1.transform.position + offset;
        mainCameraPlayer2.transform.position = player2.transform.position + offset;
        // offset the front camera behind the player
        frontCameraPlayer1.transform.position = player1.transform.position + frontOffset;
        frontCameraPlayer2.transform.position = player2.transform.position + frontOffset;

        // change player1 view pressing C button
        if (Input.GetButtonDown("CameraPlayer1"))
        {
            if (CamModePlayer1 == 1)
            {
                CamModePlayer1 = 0;
            }
            else
            {
                CamModePlayer1 += 1;
            }

            StartCoroutine(CameraChangePlayer1());
        }

        // change player2 view pressing M button
        if (Input.GetButtonDown("CameraPlayer2"))
        {
            if (CamModePlayer2 == 1)
            {
                CamModePlayer2 = 0;
            }
            else
            {
                CamModePlayer2 += 1;
            }

            StartCoroutine(CameraChangePlayer2());
        }
    }

    IEnumerator CameraChangePlayer1()
    {
        yield return new WaitForSeconds(0.01f);

        if (CamModePlayer1 == 0)
        {
            mainCameraPlayer1.gameObject.SetActive(true);
            frontCameraPlayer1.gameObject.SetActive(false);
        }

        if (CamModePlayer1 == 1)
        {
            mainCameraPlayer1.gameObject.SetActive(false);
            frontCameraPlayer1.gameObject.SetActive(true);
        }
    }

    IEnumerator CameraChangePlayer2()
    {
        yield return new WaitForSeconds(0.01f);

        if (CamModePlayer2 == 0)
        {
            mainCameraPlayer2.gameObject.SetActive(true);
            frontCameraPlayer2.gameObject.SetActive(false);
        }
        if (CamModePlayer2 == 1)
        {
            mainCameraPlayer2.gameObject.SetActive(false);
            frontCameraPlayer2.gameObject.SetActive(true);
        }
    }
}
