using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

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
}
