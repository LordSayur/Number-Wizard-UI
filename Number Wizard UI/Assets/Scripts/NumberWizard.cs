using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
        max = max + 1;
    }

    void StartGame()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}