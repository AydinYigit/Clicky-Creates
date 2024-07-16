using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIRestartButton : MonoBehaviour
{
    private Button restartButton;
    private void Awake()
    { 
       
    }

    void Start()
    {
        restartButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClicked()
    {
        EventManager.TriggerStateChanged(GameManager.GameState.start);
    }
    

    
}
