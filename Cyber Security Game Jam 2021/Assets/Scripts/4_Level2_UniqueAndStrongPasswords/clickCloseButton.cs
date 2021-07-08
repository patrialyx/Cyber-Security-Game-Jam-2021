using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickCloseButton : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene("2a_GameRoomPt3");
    }
}
