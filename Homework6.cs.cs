namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //This is beginning of Q1
        Professor prof1 = new Professor("Alice", "Java", 9000);
        Professor prof2 = new Professor("Bob", "Math", 8000);

       
        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);
        //This is ending of Q1

        //This is beginning of Q2
        Console.WriteLine("Professor " + prof1.ProfName + " teaches " + prof1.ClassTeach + ", and the salary is: " + prof1.GetSalary());
        Console.WriteLine("Professor " + prof2.ProfName + " teaches " + prof2.ClassTeach + ", and the salary is: " + prof2.GetSalary());

        
        Console.WriteLine("Student " + student1.StudentName + " enrolls " + student1.ClassEnroll + ", and the grade is: " + student1.GetGrade());
        Console.WriteLine("Student " + student2.StudentName + " enrolls " + student2.ClassEnroll + ", and the grade is: " + student2.GetGrade());

        
        double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine("The salary difference between Alice and Bob is: " + salaryDifference);

        
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine("The total grade of Lisa and Tom is: " + totalGrade);
        //This is ending of Q2
    }
}
class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string name, string teachClass, double sal)
    {
        profName = name;
        classTeach = teachClass;
        salary = sal;
    }

    public string ProfName
    {
        get { return profName; }
    }

    public string ClassTeach
    {
        get { return classTeach; }
    }

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
}
class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;
    public Student(string name, string enrollClass, double grade)
    {
        studentName = name;
        classEnroll = enrollClass;
        studentGrade = grade;
    }
    public string StudentName
    {
        get { return studentName; }
    }
    public string ClassEnroll
    {
        get { return classEnroll; }
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    public double GetGrade()
    {
        return studentGrade;
    }
}