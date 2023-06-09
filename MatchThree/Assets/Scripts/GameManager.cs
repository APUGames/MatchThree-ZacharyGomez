using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int turnsLeft;
    [SerializeField]
    private int scoreToMatch;
    [SerializeField]
    private Text turnsLeftText;
    [SerializeField]
    private Text gameResultText;
    [SerializeField]
    private GameObject gameOverPanelGameObject;
    [SerializeField]
    private GameObject AttemptsGameObject;
    [SerializeField]
    private GameObject matchesFoundGameObject;
    [SerializeField]
    private GameObject RestartButtonObject;
    private bool gameOver = false;
    private int matchesFound = 0;

    private void Start()
    {
        gameOverPanelGameObject.SetActive(false);
        RestartButtonObject.SetActive(false);

    }
    private void Update()
    {
        if (!gameOver)
        {
            if (turnsLeft <= 0)
            {
                gameOver = true;
                turnsLeftText.GetComponent<Text>().text = "0";
            }
            else
            {
                turnsLeftText.GetComponent<Text>().text = turnsLeft.ToString();

            }
            matchesFoundGameObject.GetComponent<Text>().text = matchesFound.ToString();
        }
        else
        {
            gameOverPanelGameObject.SetActive(true);
            if (matchesFound >= scoreToMatch)
            {
                gameResultText.text = "GAME WIN, RATS EXTERMINATED";
                AttemptsGameObject.SetActive(false);
                matchesFoundGameObject.SetActive(false);
                turnsLeftText.text = " ";
                RestartButtonObject.SetActive(true);

            }
            else
            {
                gameResultText.text = "THE RATS HAVE TAKEN OVER";
                AttemptsGameObject.SetActive(false);
                matchesFoundGameObject.SetActive(false);
                turnsLeftText.text = " ";
                RestartButtonObject.SetActive(true);

            }
        }
    }

    public void SubtractOneFromTurnsLeft()
    {
        turnsLeft -= 1;
    }

    public bool IsGameOver()
    {
        return gameOver;
    }

    public void AddOneToMatchesFound()
    {
        matchesFound += 1;
    }
}