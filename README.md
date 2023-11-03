# Bowling Score
This program was completed as a coding challenge to properly score a game of bowling abiding by typical bowling scoring. The program will take inputs from the user one frame at a time and then add these scores correctly and display the score for each frame as well as the final score at the end of the game. This program displays the results on the Console The two main classes in this program are the Frame class and the BowlingGame class.

Frame Class
The Frame class is used to populate values for each instantiated frame, It contains four methods, one for population of frame values for frames 1-9, another for population of values in the unique 10th frame, and then a Validation method for the first and second throw to ensure valid entries.

BowlingGame Class
The BowlingGame class is the real logic of the program. In the FillFrame method, it creates instances of the Frame class and adds them to a list of frames. It then runs through the frames list andd calculates the score accordingly based on strikes and spares rolled. It also has its own piece of logic to handle scoring for the 9th frame as it depends on the 10th frame which has unique scoring rules. It finally iterates through the scores for each frame and lists them on the Console.
