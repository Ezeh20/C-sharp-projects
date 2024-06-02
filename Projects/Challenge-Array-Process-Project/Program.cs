/*
This console project automates a grading process
The final results prints the student's name, score, grade and extra credit sore
The programm should also show the effect the extra credit on the student's final score
*/



int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScore = { };
int[] extraCredits = { };

Console.Write($"Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n\n");

foreach (string student in studentNames)
{
    int counter = 0;
    int countExtraCredit = 0;
    int sumScore = 0;
    int examScore = 0;
    decimal averageScore = 0;
    decimal bonusCredit = 0;
    decimal points = 0;
    decimal sumExtraCredits = 0;
    string studentGrade = "";

    string currentStudent = student;

    if (currentStudent == "Sophia")
    {
        studentScore = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScore = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScore = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScore = loganScores;
    }


    //To get the main exam score, add the first 5 scores.
    for (int i = 0; i < studentScore.Length; i++)
    {
        examScore += studentScore[i];
        if (i == 4)
        {
            break;
        }
    }

    extraCredits = studentScore.Skip(examAssignments).ToArray();
    foreach (int extraCredit in extraCredits)
    {
        countExtraCredit++;
        sumExtraCredits += extraCredit;
    }

    foreach (int score in studentScore)
    {
        counter++;
        if (counter > examAssignments)
        {
            sumScore += score / 10;
        }
        else
        {
            sumScore += score;
        }
    }

    points = ((decimal)sumExtraCredits / 10) / examAssignments;
    bonusCredit = (decimal)sumExtraCredits / countExtraCredit;
    averageScore = ((decimal)examScore / examAssignments) + points;

    if (averageScore >= 97)
        studentGrade = "A+";
    else if (averageScore >= 93)
        studentGrade = "A";
    else if (averageScore >= 90)
        studentGrade = "A-";
    else if (averageScore >= 87)
        studentGrade = "B+";
    else if (averageScore >= 83)
        studentGrade = "B";
    else if (averageScore >= 80)
        studentGrade = "B-";
    else if (averageScore >= 77)
        studentGrade = "C+";
    else if (averageScore >= 73)
        studentGrade = "C";
    else if (averageScore >= 70)
        studentGrade = "C-";
    else if (averageScore >= 67)
        studentGrade = "D+";
    else if (averageScore >= 63)
        studentGrade = "D";
    else if (averageScore >= 60)
        studentGrade = "D-";
    else
        studentGrade = "F";

    Console.WriteLine(
        $"{currentStudent}\t\t{(decimal)examScore / 5}\t\t{averageScore}\t{studentGrade}\t{bonusCredit} ({points} pts)"
    );
}
