using System;
using UnityEngine;


public class Practice : MonoBehaviour
{

    void Start()
    {
        var level = "Level 1";

        if (level == "Level 1")
        {
            Console.WriteLine("Starting Level 1");
        }

        var score = 100;

        if(score == 100)
        {
            Console.WriteLine("Game Won!");
        }
        if(score < 100)
        {
            Console.WriteLine("You need more points!");
        }
        if(score > 100)
        {
            Console.WriteLine("New High Score!");
        }
    }

    void Level()
    {
        var level = "Level 2";

        if(level == "Level 3")
        {
            Console.WriteLine("Starting Level 3!");
        }
        else
        {
            Console.WriteLine("Level Locked!");
        }

        void Loops()
        {
            for (var i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}