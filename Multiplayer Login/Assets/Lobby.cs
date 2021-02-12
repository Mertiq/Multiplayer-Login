using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class Lobby : MonoBehaviour
{
    [SerializeField] GameObject [] roomsPanels;

    private void Update()
    {
        CreateLobby();
    }

    public void CreateLobby() 
    {
        for (int i = 0; i < PhotonNetwork.CountOfRooms; i++)
        {
            if(i < 8)
            {
                roomsPanels[i].SetActive(true);
                Debug.Log(PhotonNetwork.MasterClient.UserId);
                //roomsPanels[i].GetComponentInChildren<Text>().text ="Join "+ PhotonNetwork.MasterClient.UserId + "'s Room";
            }
        }
    }

    public void deneme()
    {
        Debug.Log("asdakljsdklasd");
    }

    public void CreateRoom()
    {
        PhotonNetwork.JoinOrCreateRoom(PhotonNetwork.AuthValues.UserId, new RoomOptions { MaxPlayers = 2, IsOpen = true, IsVisible = true }, TypedLobby.Default);
    }

    public void JoinRoom(string s)
    {
        PhotonNetwork.JoinOrCreateRoom(s, new RoomOptions { MaxPlayers = 2, IsOpen = true, IsVisible = true }, TypedLobby.Default);
    }
}
