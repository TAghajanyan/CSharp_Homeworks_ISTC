using System;

namespace SecondStage.ExceptionHandling
{
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }
        public InvalidStudentNameException(string message) : base($"Invalid Student Name: {message}") { }
    } 
}
