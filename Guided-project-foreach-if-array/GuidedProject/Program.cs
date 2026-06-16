using System;

/*
Daniel Turek
learn.microsoft.com 
https://learn.microsoft.com/en-us/training/modules/guided-project-arrays-iteration-selection/5-exercise-implement-selection-statements

Doing the lesson so no select case or mutlidimensional arrays

*/

// initialize variables - graded assignments 
int examAssignments = 5;

//new scores with extra credit
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
        
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;


    int sumStudentScores = 0;
    decimal currentStudentGrade = 0;
    int assignment = 0; //counter for assignments

    foreach( int score in studentScores)
    {
        assignment++;
        //check for extra credit, which is 10% of the score added, rounded down
        if (assignment <= examAssignments)
            sumStudentScores += score;
        else 
            sumStudentScores += score / 10;
    } 

    currentStudentGrade = (decimal)sumStudentScores / examAssignments;
    string letterGrade = "";

    if ((currentStudentGrade / 10) >= 9)
        {letterGrade = "A";}
    else if ((currentStudentGrade / 10) >= 8)
        {letterGrade = "B";}
    else if ((currentStudentGrade / 10) >= 7)
        {letterGrade = "C";}
    else if ((currentStudentGrade / 10) >= 6)
        {letterGrade = "D";}           

    if (currentStudentGrade >= 60)
    {
        if (currentStudentGrade % 10 >= 7)
            {letterGrade += "+";}
        else if (currentStudentGrade % 10 < 3)
            {letterGrade += "-";}
    }    
    else letterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{letterGrade}"); 
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
