using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    //Task 13: Implement a shoot ability for the player racket. The ability should only be activated when a 
    //Gift object falls on the racket. The shot objects should be a new class (e.g. Bullet) 
    //and should destroy normal Block objects (and be destroyed on collision with any block). 
    //Use the engine and ShootPlayerRacket method you implemented in task 4, but don't add items in any of the engine 
    //lists through the ShootPlayerRacket method. Also don't edit the Racket.cs file. Hint: you should have a 
    //ShootingRacket class and override its ProduceObjects method.

    public class Racket : GameObject
    {
        public new const string CollisionGroupString = "racket";

        public int Width { get; protected set; }

        public Racket(MatrixCoords topLeft, int width) : base(topLeft, new char[,] { { '=' } })
        {
            this.Width = width;
            this.body = GetRacketBody(this.Width);
        }

        char[,] GetRacketBody(int width)
        {
            char[,] body = new char[1, width];

            for (int i = 0; i < width; i++)
            {
                body[0, i] = '=';
            }

            return body;
        }

        public void MoveLeft()
        {
            this.topLeft.Col--;
        }

        public void MoveRight()
        {
            this.topLeft.Col++;
        }

        public override string GetCollisionGroupString()
        {
            return Racket.CollisionGroupString;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block" || otherCollisionGroupString == Racket.CollisionGroupString || otherCollisionGroupString == "ball";
        }

        public override void Update()
        {
        }
    }
}