using Esercizio_9_Data_Coll_.NET;

class Program
{
    static void Main()
    {   
        
        List<Student> students = new List<Student>()
        {
            new Student("Pippo", 8),
            new Student("Mario", 6),
            new Student("Jack", 7),
            new Student("Mimmo", 10),
            new Student("Erik", 8),
            new Student("Roberto", 5),
            new Student("Gianluca", 6),
            new Student("Ruggero", 9),
            new Student("Dodo", 10),
            new Student("Mimi", 9)
        };

        double avg = CalculateAvarage(students);
        Console.WriteLine($"The avarage of the students is : {avg}");
        Console.WriteLine();
        Student stud = MaximumGrade(students);
        Console.WriteLine($"The student with the better grade : {stud.Name}");

 }

    static double CalculateAvarage(List<Student> students)
    {
        double sum = 0;

        foreach (Student student in students)
        {
            sum += student.Grade;

        }
        return sum / students.Count;

    }

    static Student MaximumGrade(List<Student> students)
    {
        Student studMaxGrade = students[0];
        foreach (Student student in students)
        {
            if (student.Grade > studMaxGrade.Grade)
                studMaxGrade = student;
        }
        return studMaxGrade;

    }


}