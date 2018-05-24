using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    private int guess;
    private int max;
    private int min;
    public int maxGuesses = 5;
    public Text guessText;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        max++;
    }

    public void GuessHigher()
    {
        //raises the floor to the guesses
        min = guess;
        NextGuess();
        maxGuesses--;
        if (maxGuesses == 0)
            ThatsIt();
        guessText.text = guess.ToString();
    }

    public void GuessLower()
    {
        //lowers the ceiling to the guesses
        max = guess;
        NextGuess();
        maxGuesses--;
        if (maxGuesses == 0)
            ThatsIt();
        guessText.text = guess.ToString();
    }

    public void ThatsIt()
    {
        SceneManager.LoadScene("Win");
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}
