using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo instance;

    public string playerName;
    public string hiScoreName;
    public int hiScorePoints;

    void Awake()
    {
        //singleton
        if (instance != null) {
            Destroy(gameObject);
            return;
        }

        //set instance
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    
}
