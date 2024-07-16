using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
   // I wrote it because it can be useful in the future
    public GameState state;
    private Coroutine spawnCoroutine;
    public static int gamedifficulty;
    [SerializeField] private TargetSpawner targetSpawner;
    public override void Awake()
    {
        EventManager.StateChanged += UpdateGameState;
    }
    // game manager is singleton and ı will not destroy it therefore don't need any unsubscription
    public void UpdateGameState(GameState newState)
    {
        state = newState;
        switch (newState)
        {
            case GameState.start:

                break;
            case GameState.playing:
                HandlePlaying();
                break;
            
            case GameState.gameOver:
                HandleGameOver();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
        // invoke StateChanged event
        //EventManager.TriggerStateChanged(newState);

    }

    public enum GameState
    {
        start,
        playing,
        gameOver,
    }

    private void HandlePlaying()
    {
        spawnCoroutine = StartCoroutine(targetSpawner.SpawnTargetCoroutine(gamedifficulty));
    }

    private void HandleGameOver()
    {
        StopCoroutine(spawnCoroutine);
        
    }




    /*public void RestartGame()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }*/


}
