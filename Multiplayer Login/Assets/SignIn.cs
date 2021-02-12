using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignIn : MonoBehaviour
{

    [SerializeField] InputField nicknameInput;
    [SerializeField] InputField passwordInput;

    public void DoSignIn()
    {
        if(nicknameInput.text == "" || passwordInput.text == "")
        {
            Debug.Log("fill the blanks");
            Debug.Log(nicknameInput.text);
            Debug.Log(passwordInput.text);
        }
        else
        {
            PlayerPrefs.SetString("nickname", nicknameInput.text);
            PlayerPrefs.SetString("pass", passwordInput.text);
            nicknameInput.text = "";
            passwordInput.text = "";
            Debug.Log("Sign in Success");
        }
    }

}
