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

        LoadScores();
    }

    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public string hiScoreName;
        public int hiScorePoints;
    }

    public void SaveScores()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.hiScoreName = hiScoreName;
        data.hiScorePoints = hiScorePoints;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScores()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path)) {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            hiScoreName = data.hiScoreName;
            hiScorePoints = data.hiScorePoints;
        }
    }
}
