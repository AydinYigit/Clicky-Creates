using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowGameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    private void Awake()
    {
        EventManager.StateChanged += GameOverMessage;
        //Debug.Log("abone oldum");
    }

    void Start()
    {
        //gameOverText = GetComponent<TextMeshProUGUI>();
    }

    private void OnDestroy()
    {
        EventManager.StateChanged -= GameOverMessage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOverMessage(GameManager.GameState state)
    {
        if (state == GameManager.GameState.gameOver)
        {
            ShowGameOverMessage();
        }
        //Debug.Log("ui gözüktü");
        ShowGameOverMessage();
    }

     void ShowGameOverMessage()
    {
        if(gameOverText.gameObject.activeSelf == false)
            gameOverText.gameObject.SetActive(true);
    }
}
