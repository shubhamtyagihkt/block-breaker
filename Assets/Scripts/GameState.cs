using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    // config parameters
    [Range(0.1f, 10.0f)] [SerializeField] float gameSpeed = 1f;

    // state variables
    [SerializeField] int scorePerBlockDestroyed = 25;

    [SerializeField] int currentScore = 0;

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void addToScore()
    {
        currentScore += scorePerBlockDestroyed;
    }
}
