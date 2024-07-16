using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : Singleton<UIManager>
{
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private Button restartButton;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI scoreCounterText;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.StateChanged += UpdateGameStateUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateGameStateUI(GameManager.GameState newState)
    {
        
        switch (newState)
        {
            case GameManager.GameState.start:
                
                HandleStart();
                break;
            
            case GameManager.GameState.playing:
                
                HandlePlaying();
                break;
            
            case GameManager.GameState.gameOver:
                
                HandleGameOver();
                break;
        }
    }

    private void HandleStart()
    {
        restartButton.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        titleScreen.SetActive(true);
    }
    private void HandlePlaying()
    {
        scoreCounterText.gameObject.SetActive(true);
        titleScreen.SetActive(false);
    }
    private void HandleGameOver()
    {
        scoreCounterText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
    }
}
