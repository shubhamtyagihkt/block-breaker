using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // paramters
    [SerializeField] int breakableBlocks; // serialize for debuggin purposes

    // cached reference
    SceneLoader sceneLoader;

    GameState gameState;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        gameState = FindObjectOfType<GameState>();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        gameState.AddToScore();
        if (breakableBlocks == 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
