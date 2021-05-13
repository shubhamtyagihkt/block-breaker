using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameState : MonoBehaviour
{
    // config parameters
    [Range(0.1f, 10.0f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int scorePerBlockDestroyed = 25;
    [SerializeField] TextMeshProUGUI scoreText;

    // state variables
    [SerializeField] int currentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameState>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += scorePerBlockDestroyed;
        FindObjectOfType<TextMeshProUGUI>().text = currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
