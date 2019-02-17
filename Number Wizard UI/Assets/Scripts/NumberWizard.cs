using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    public void OnPressLower()
    {
        max = guess;
        guess = (max + min) / 2;
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    void StartGame()
    {
        guess = 500;
        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}