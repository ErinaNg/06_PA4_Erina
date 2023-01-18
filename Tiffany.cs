using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int num;


    [SerializeField]
    private GameObject btn;

    [SerializeField]
    private InputField input;

    [SerializeField]
    private Text text;

    [SerializeField]
    private Text DebugText;
    private void Awake()
    {
        num = Random.Range(1, 9);
        text.text = "Guess A Number Between 1 and 9";

         Debug.Log("System Number " + num);
    }


    public void GetInput(string guess)
    {
        //Debug.Log("You Entered " + guess);
        
        try
        {
            CompareGuesses(int.Parse(guess));
            input.text = "";
        }
        catch
        {
            debug();
        }
        
    }

    void debug()
    {
        DebugText.text = "Please type a whole number or a number 1 to 9";
    }

    void CompareGuesses(int guess)
    {
        if(guess < 1 || guess > 9)
        {
            debug();
        }
        else if (guess == num)
        {
             SceneManager.LoadScene("GameWin");
        }

        else if (guess != num)
        {
             SceneManager.LoadScene("GameOver");
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("GameScene");
    }
}
