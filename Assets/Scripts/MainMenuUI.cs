using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] TMP_Text HighScoreText;
    [SerializeField] TMP_Text playerNameInput;
    // Start is called before the first frame update
    public void Start()
    {
        HighScoreText.text = "High Score: " + DataManager.Instance.highScorePlayerName + ": " + DataManager.Instance.highScore;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetplayerName()
    {
        DataManager.Instance.currentPlayerName = playerNameInput.text;
        
    }

    
}
