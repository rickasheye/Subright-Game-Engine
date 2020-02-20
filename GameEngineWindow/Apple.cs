﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;

namespace GameEngineWindow
{
    public class Apple
    {
        public Vector2 position;
        public bool deleted;
        public int randString;

        public Apple(Vector2 position_)
        {
            position = position_;
            Random rand = new Random();
            randString = rand.Next(100, 1000);
        }

        public void render()
        {
            if (deleted == false)
            {
                if (Vector2.Distance(position, Form1.playerPosition) <= 10)
                {
                    //delete
                    deleted = true;
                    GameEngine.PlayerValues.SetIntValue("Apples", (int)GameEngine.PlayerValues.GetInteger("Apples") + 1);
                }
                GameEngine.Canvas.DrawRect(new Rectangle(new Vector2(10, 10), position), new Color(255, 0, 0), "Apple " + randString); 
            }else if(deleted == true)
            {
                GameEngine.Canvas.ClearPixels("Apple " + randString);
            }
        }
    }
}
