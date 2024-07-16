using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager:  Singleton<EventManager>
{
    // Start is called before the first frame update
    public static event Action<int> objectDestroyed;
    public static event Action<GameManager.GameState> StateChanged; 
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static  void TriggerOnObjectDestroyed(int number)
    {
        objectDestroyed?.Invoke(number);
    }

    public static void TriggerStateChanged(GameManager.GameState gameState)
    {
        StateChanged?.Invoke(gameState);
        //Debug.Log("State değişti");
    }
}
