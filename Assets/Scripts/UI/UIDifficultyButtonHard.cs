using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDifficultyButtonHard : MonoBehaviour
{
    public void OnButtonClicked()
    {
        GameManager.gamedifficulty = 3;
        EventManager.TriggerStateChanged(GameManager.GameState.playing);
        
    }
}
