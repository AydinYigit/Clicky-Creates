using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDifficultyButtonMedium : MonoBehaviour
{
    public void OnButtonClicked()
    {
        GameManager.gamedifficulty = 2;
        EventManager.TriggerStateChanged(GameManager.GameState.playing);
        
    }
}
