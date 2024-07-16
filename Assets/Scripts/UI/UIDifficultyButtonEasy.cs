using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDifficultyButtonEasy : MonoBehaviour
{
    
    public void OnButtonClicked()
    {
        GameManager.gamedifficulty = 1;
        EventManager.TriggerStateChanged(GameManager.GameState.playing);
        
    }
}
