using UnityEngine;
using System.Collections;
using System.Linq;
using System.Text;

public enum GameState
{
    Intro,
    Playing,
    Dead
}

public static class GameStateManager
{
    public static GameState GameState { get; set; }
    //public static DeathCount 

    static GameStateManager()
    {
        GameState = GameState.Playing;
    }
}