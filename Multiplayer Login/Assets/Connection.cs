using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class Connection: MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject lobbyPanel;

    public static void Connect()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        lobbyPanel.SetActive(true);
        GetComponent<Lobby>().CreateLobby();
    }


    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("girdi");
    }


}
