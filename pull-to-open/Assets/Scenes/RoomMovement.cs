using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMovement : MonoBehaviour
{
    /*
     *  Back = -254.5
     *  Left = -114.5
     *  Front - 25.5
     *  Right = 164.5
     */

    public GameObject RoomCamera;

    public void NavLeft()
    {
        RoomCamera.transform.position = new Vector3(-114.5f, 95f, -150f);
    }

    public void NavRight()
    {
        RoomCamera.transform.position = new Vector3(164.5f, 95f, -150f);
    }

    public void NavFront()
    {
        RoomCamera.transform.position = new Vector3(25.5f, 95f, -150f);
    }

    public void NavBack()
    {
        RoomCamera.transform.position = new Vector3(-254.5f, 95f, -150f);
    }
}
