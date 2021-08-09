using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartManager : MonoBehaviour
{
    public TMP_InputField playerNameInput;

    public void Start()
    {
        if (PlayerInfo.instance.playerName != null) {
            playerNameInput.text = PlayerInfo.instance.playerName;
        }
    }
    
    public void OnStartButtonClick()
    {
        PlayerInfo.instance.playerName = playerNameInput.text;
        
        //Go to main scene
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }
}
