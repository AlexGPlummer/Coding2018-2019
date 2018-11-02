using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    static GameManager instance;
    public static GameManager Instance
    {
        get { return instance ?? ((instance = new GameManager())); }
    }
    public  Square square
    {
        get; set;
    }
    private GameManager()
    {
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }
    private void Update()
    {
    }  
    public class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }
}

