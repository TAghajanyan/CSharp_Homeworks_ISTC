namespace SecondStage.ExceptionHandling
{
    class Student
    {
        public string StudentName { get; private set; }
        public uint StudentID { get; private set; }

        public Student(string studentName, uint studentID)
        {
            StudentName = studentName;
            StudentID = studentID;
        }
    }
}
