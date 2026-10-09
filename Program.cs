using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student1 = new Student(); //sanya
        Student student2 = new Student("oleg", 'M' );
        Student student3 = new Student("maria", 4, 'W');
        Student student4 = new Student(student3); //maria

        Console.WriteLine(student1);
        Console.WriteLine(student2);
        Console.WriteLine(student3);
        Console.WriteLine(student4);
        student2.Course = '2';
        student3.Name = "masha";
        //student4.Gender = '';
        //Console.WriteLine(student2.Course)
        Console.WriteLine(student2);
        Console.WriteLine(student3.Name);
        Console.WriteLine(student4.Gender);

        student4.Course = 7;
        Console.WriteLine(student4);
        student4.DeleteStudent();

        int x = 0;
        Validator validator = new Validator();
        x = validator.ReadInt("Введите число: ");

        Student student = new Student("Petr", x, 'A');
        Console.WriteLine(student);
        
    }
}