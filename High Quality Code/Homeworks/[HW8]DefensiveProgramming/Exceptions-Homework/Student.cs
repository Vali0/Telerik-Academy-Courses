using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName, lastName;

    public IList<Exam> Exams { get; set; }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("First name can't be null or empty");
            }
            
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Last name can't be null or empty");
            }

            this.lastName = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null || this.Exams.Count <= 0)
        {
            throw new ArgumentNullException(string.Format("There are no exams for student {0} {1}!", this.FirstName, this.LastName));
        }
        
        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null || this.Exams.Count == 0)
        {
            throw new ArgumentNullException("Can't calculate average exam result -> there is no exams.");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                          ((double)examResults[i].Grade - examResults[i].MinGrade) /
                          (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}