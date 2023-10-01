using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager _gameManager;
    private List<string> objects = new List<string>() { "Apple", "Cookies", "Cake" };
    public Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score + "";
    }

    public bool CheckMatch(string nameObject)
    {
        if (objects[0] == nameObject)
        {
            score++;
            objects.RemoveAt(0);
            return true;
        }

        return false;
    }
}