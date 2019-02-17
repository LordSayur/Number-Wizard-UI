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

    void Start()
    {
        StartGame();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    void StartGame()
    {
        NextGuess();
    }

    void NextGuess()
    {
        MakeAGuess();
        UpdateGuessText();
    }

    private void MakeAGuess()
    {
        guess = Random.Range(min, max + 1);
    }

    private void UpdateGuessText()
    {
        guessText.text = guess.ToString();
    }
}