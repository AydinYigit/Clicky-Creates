using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowingScore : MonoBehaviour
{
    // Start is called before the first frame update
    private int score = 0;
    private TextMeshProUGUI textMeshPro;
    void Start()
    {
        EventManager.objectDestroyed += ShowScore;
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        score = 0;
    }

    private void OnDestroy()
    {
        EventManager.objectDestroyed -= ShowScore;
    }

    void ShowScore(int number)
    {
        score+= number;
        textMeshPro.text = "Score: " + score;
    }
}
