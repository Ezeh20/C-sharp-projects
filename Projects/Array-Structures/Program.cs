int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 88, 96 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

int sophiaSum = 0;

foreach (int score in sophiaScores)
{
    sophiaSum += score;
}

Console.WriteLine((decimal)sophiaSum / currentAssignments);
