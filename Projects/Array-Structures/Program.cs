﻿int currentAssignments = 5;

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
    int studentSum = 0;
    int studentScore = 0;
    string studentGrade;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    foreach (int score in studentScores)
    {
        studentSum += score;
    }
    studentScore = (decimal)studentSum / currentAssignments;

    if (studentScore >= 97)
        studentGrade = "A+";
    else if (studentGrade >= 93)
        studentGrade = "A";
    else if (studentScore >= 90)
        studentGrade = "A-";
    else if (studentScore >= 87)
        studentGrade = "B+";
    else if (studentScore >= 83)
        studentGrade = "B";
    else if (studentScore >= 80)
        studentGrade = "B-";
    else if (studentScore >= 77)
        studentGrade = "C+";
    else if (studentScore >= 73)
        studentGrade = "C";
    else if (studentScore >= 70)
        studentGrade = "C-";
    else if (studentScore >= 67)
        studentGrade = "D+";
    else if (studentScore >= 63)
        studentGrade = "D";
    else if (studentScore >= 60)
        studentGrade = "D-";
    else
    studentGrade ="F";

    Console.WriteLine($"{currentStudent}\t\t{studentGrade}");
}
