int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 88, 96 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

foreach (string studentName in studentNames)
{
    string currentStudent = studentName;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int studentSum = 0;
    int studentGrade = 0;
    foreach (int score in studentScores)
    {
        studentSum += score;
    }
    Console.WriteLine($"{currentStudent}\t\t{(decimal)studentSum / currentAssignments}");
}
