using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo instance;

    public string playerName;

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
