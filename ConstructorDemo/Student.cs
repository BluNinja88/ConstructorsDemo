using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public double AverageScore { get; private set; }

        private int score1;
        public int Score1
        {
            get { return score1; }
            set { score1 = value; UpdateAverageScore(); }
        }
        private int score2;

        public int Score2
        {
            get { return score2; }
            set { score2 = value; UpdateAverageScore(); }
        }

        public double HighScore
        {
            get
            {
                if (score1 > score2)
                {
                    return score1;
                }
                else
                {
                    return score2;
                }
            }
        }

        //private string name;
        //private int idNumber;
        //private double score1;
        //private double score2;
        //private double averageScore;

        //public static void DoStuff()
        //{
        //    Student molly = new Student();
        //    molly.name = "Molly";
        //    molly.idNumber = 42;
        //    Console.WriteLine("Molly: {0}", molly.name);
        //    Console.WriteLine("Molly: {0}", molly.idNumber);

        //    Student someStudent = new Student();
        //    Console.WriteLine("someStudent: {0}", someStudent.name);
        //    Console.WriteLine("someStudent: {0}", someStudent.idNumber);
        //}

        public Student()
        {
            
        }

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string newName)
        //{
        //    name = newName;
        //}

        //public int GetIdNumber()
        //{
        //    return idNumber;
        //}

        //public void SetIdNumber(int newIdNumber)
        //{
        //    idNumber = newIdNumber;
        //}

        //public double GetScore1()
        //{
        //    return score1;
        //}

        //public void SetScore1(double newScore1)
        //{
        //    score1 = newScore1;
        //    UpdateAverageScore();
        //}

        //public double GetScore2()
        //{
        //    return score2;
        //}

        //public void SetScore2(double newScore2)
        //{
        //    score2 = newScore2;
        //    UpdateAverageScore();
        //}

        //public double GetAverageScore()
        //{
        //    return averageScore;
        //}

        //private void UpdateAverageScore()
        //{
        //    averageScore = (score1 + score2) / 2;
        //}

        //public double GetHighScore()
        //{
        //    if (score1 > score2)
        //    {
        //        return score1;
        //    }
        //    else
        //    {
        //        return score2;
        //    }
        //}

        //public Student(int newIdNumber)
        //{
        //    this.name = "Unknown";
        //    this.idNumber = newIdNumber;
        //}

        //public Student(string newName)
        //{
        //    this.name = newName;
        //    this.idNumber = -1;
        //}

        //public Student(string newName, int newIdNumber)
        //{
        //    this.name = newName;
        //    this.idNumber = newIdNumber;
        //}

    }
}
