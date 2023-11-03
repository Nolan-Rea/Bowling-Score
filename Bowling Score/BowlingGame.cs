namespace BowlerScorer
{

    class BowlingGame
    {
        
        public void StartGame()
        {
            // Initializes a list where an instance of each frame will be stored
            List<Frame> frames = new List<Frame>();
            int score = 0;
            //Loops through each fram and populates the values by calling methods in the Frame class and then adds each frame to the frames list
            for (int i = 1; i < 10; i++)
            {

                Frame frame = new();
                Console.WriteLine($"Frame {i}");
                frame.FillFrame();
                frames.Add(frame);

            }
            //Specific code to handle the differences in possible rolls in the tenth frame and then adds the tenth frame to the list of frames
            Frame frameTen = new();
            Console.WriteLine("Frame 10");
            frameTen.frameTen();
            frames.Add(frameTen);
            //Iterates through the list of frames and scores spares and strikes accordingly for frames 1-8
            for (int i = 0; i < 10; i++)
            {

                if (i > 0 && frames[i - 1].isSpare)
                {
                    frames[i - 1].frameScore = 10 + frames[i].firstThrow;
                }
                if (i > 1 && frames[i - 2].isStrike)
                {
                    if (frames[i - 1].isStrike)
                    {
                        frames[i - 2].frameScore = 20 + frames[i].firstThrow;
                    }
                    else if (frames[i - 1].isSpare)
                    {
                        frames[i - 2].frameScore = 20;
                    }

                    else
                    {
                        frames[i - 2].frameScore = 10 + frames[i - 1].frameScore;
                    }

                }


            }
            //Same logic as the loop, but this code is needed to handle the scoring of 9th frame as it may rely on the tenth frame with unique scoring rules
             if(frames[8].isStrike)
             {
                if (frames[9].firstThrow == 10)
                {
                    frames[8].frameScore = 20 + frames[9].secondThrow;
                }
                else if (frames[9].firstThrow + frames[9].secondThrow == 10 && frames[9].secondThrow != 0)
                {
                    frames[8].frameScore = 20;
                }
                else
                {
                    frames[8].frameScore = 10 + frames[9].firstThrow + frames[9].secondThrow;
                }

            }
            BowlingPicture();
            //Iterates through the list of frames displaying the score for each frame
            for (int j = 0; j < 10; j++)
            {
                score += frames[j].frameScore;
                Console.WriteLine($"Frame {j + 1} Score: {score}");
            }

            Console.WriteLine($"Final Score: {score}");

        }

        public static void BowlingPicture()
        {
            Console.WriteLine("");
            Console.WriteLine("          |\"\"\"\"\"| ");
            Console.WriteLine(@"          |iIjIi|");
            Console.WriteLine(@"        //       \\");
            Console.WriteLine(@"       //         \\");
            Console.WriteLine(@"      //           \\");
            Console.WriteLine(@"     //             \\");
            Console.WriteLine(@"    //               \\");
            Console.WriteLine(@"   //                 \\");
            Console.WriteLine(@"  //                   \\");
            Console.WriteLine(@" //                     \\");
            Console.WriteLine(@"//   /  /   |   \\  \\   \\");
            Console.WriteLine("");
            Console.WriteLine(@"  ___");
            Console.WriteLine(@" /o o\");
            Console.WriteLine(@"|  o  |");
            Console.WriteLine(@" \___/");
            Console.WriteLine("");
        }

    }

}