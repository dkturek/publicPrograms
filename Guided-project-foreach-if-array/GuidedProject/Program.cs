using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;
int[] sophiaScores = new int[] {sophia1, sophia2, sophia3, sophia4, sophia5};

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;
int[] andrewScores = new int[] {andrew1, andrew2, andrew3, andrew4, andrew5};

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;
int[] emmaScores = new int[] {emma1, emma2, emma3, emma4, emma5};

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;
int [] loganScores = new int[] {logan1, logan2, logan3, logan4, logan5};

/* Replaced with generic studentScores
int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;
*/

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");


foreach (string name in studentNames)
{
    string currentStudent = name;
        
    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }   
    if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }   
    if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }   
    if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }   

    int sumStudentScores = 0;
    decimal currentStudentGrade = 0;

    foreach( int score in studentScores)
    {
        sumStudentScores += score;
    } 

    currentStudentGrade = (decimal)sumStudentScores / currentAssignments;
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?"); 
}

/*
//sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

//sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

//Console.WriteLine("Student\t\tGrade\n");
//Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");
*/
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
