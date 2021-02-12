using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{

    [SerializeField] InputField nicknameInput;
    [SerializeField] InputField passwordInput;

    public void DoLogin()
    {
        if (nicknameInput.text == "" || passwordInput.text == "")
        {
            Debug.Log("fill the blanks");
        }
        else
        {
            if(nicknameInput.text == PlayerPrefs.GetString("nickname") && passwordInput.text == PlayerPrefs.GetString("pass"))
            {
                Debug.Log("Login Success");
                PhotonNetwork.AuthValues = new AuthenticationValues(nicknameInput.text);
                nicknameInput.text = "";
                passwordInput.text = "";
                Connection.Connect();
            }
        }
    }
}
