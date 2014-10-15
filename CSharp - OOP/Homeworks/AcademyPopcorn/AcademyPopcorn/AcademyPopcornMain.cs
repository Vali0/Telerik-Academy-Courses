using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // Look below to enable features
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 39;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            { 
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);
            }

            // Task 01: The Engine class has a hardcoded sleep time (search for "System.Threading.Sleep(500)".
            //Make the sleep time a field in the Engine and implement a constructor, 
            //which takes it as an additional parameter.

            // indestructible walls
            for (int i = startRow; i < WorldRows; i++)
            {
                IndestructibleBlock leftWall = new IndestructibleBlock(new MatrixCoords(i,0));
                engine.AddObject(leftWall);
                IndestructibleBlock rightWall = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));
                engine.AddObject(rightWall);
            }

            // indestructible roof
            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock top = new IndestructibleBlock(new MatrixCoords(2, i));
                engine.AddObject(top);
            }

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 2));
            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);
            // uncomment following lines to enable features
            // Creating shooting racket
            /*
            ShoothingRacket theRacket = new ShoothingRacket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);
            TrailObject trail = new TrailObject(10, new MatrixCoords(10, 6), new char[1, 1] { { 'x' } });
            engine.AddObject(trail);
            */
            //Task 07: Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            /*
            MeteoritBall meteor = new MeteoritBall(new MatrixCoords(WorldRows/2, 0), new MatrixCoords(-1, 2));
            engine.AddObject(meteor);
            */
            // Task 09: Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in AcademyPopcornMain.cs file
            /*
            UnstoppableBall unstoppableBall = new UnstoppableBall(new MatrixCoords(WorldRows - 1, WorldCols / 2), new MatrixCoords(-1, -2));
            engine.AddObject(unstoppableBall);
            Adding unpassable block
            for (int i = 0; i < WorldRows; i++)
            {
            UnpassableBlock unpassableBlock = new UnpassableBlock(new MatrixCoords(i, 1));
            engine.AddObject(unpassableBlock);
            }
            */
            // Adding exploding block
            
            ExplodingBlock explodingBlock = new ExplodingBlock(new MatrixCoords(startRow+1, 14));
            Block bl = new Block(new MatrixCoords(startRow + 1, 13));
            engine.AddObject(bl);
            bl = new Block(new MatrixCoords(startRow + 1, 15));
            engine.AddObject(bl);
            bl = new Block(new MatrixCoords(startRow + 1, 16));
            engine.AddObject(bl);
            engine.AddObject(explodingBlock);
            
            // Adding gift block
            /*
            * GiftBlock gift = new GiftBlock(new MatrixCoords(startRow + 1, 14));
            engine.AddObject(gift);
            */
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            int sleepTime = 250;

            Engine gameEngine = new Engine(renderer, keyboard,sleepTime);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}