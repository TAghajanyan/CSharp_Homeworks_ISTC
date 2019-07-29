using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[6];
            students[0] = new Student("John", 234564);
            students[1] = new Student("Steve", 234659);
            students[2] = new Student("Alice", 234648);
            students[3] = new Student("John", 235894);
            students[4] = new Student("Bill", 124598);
            students[5] = new Student("Alice", 165484);

            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i+1; j < students.Length; j++)
                {
                    try
                    {
                        if (students[i].StudentName == students[j].StudentName)
                        {
                            throw new InvalidStudentNameException(students[i].StudentName);
                        }
                    }
                    catch (InvalidStudentNameException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

        }
    }
}
