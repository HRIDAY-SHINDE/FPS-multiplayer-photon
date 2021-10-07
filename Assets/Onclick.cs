using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class Onclick : MonoBehaviour
{
    

    public void OnClick()
    {
        PhotonNetwork.LeaveRoom();
       
        SceneManager.LoadScene("Menu");
       
    }
    public void Exit()
    {
        Application.Quit();
    }
}
    
