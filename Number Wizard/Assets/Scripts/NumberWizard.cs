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
        max = 1001;
        min = 1;
        NextGuess();
        //Offset the NextGuess countdown for max guess
        maxGuesses++;
    }

    public void GuessHigher()
    {
        //raises the floor to the guesses
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        //lowers the ceiling to the guesses
        max = guess;
        NextGuess();
    }

    public void ThatsIt()
    {
        SceneManager.LoadScene("Win");
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        maxGuesses--;
        if (maxGuesses == 0)
            ThatsIt();
        guessText.text = guess.ToString();
    }
}
