internal class Student
{
    //поля
    private string name;
    private int course;
    private char gender;
    
    //конструкторы
    //по умолчанию (без параметров)
    public Student()
    {
        name = "sanya";
        course = 1;
        gender = 'M';
    }
    
    //с параметрами
    public Student(string name, int course, char gender)
    {
        Name = name;
        Course = course;
        Gender = gender;
    }

    public Student(string name, char gender)
    {
        Name = name;
        Gender = gender;
        course = 1;
    }
    //копирования
    public Student(Student student)
    {
        this.name = student.name;
        this.course = student.course;
        this.gender = student.gender;
    }
    
    //свойства
    public string Name
    {
        get { return name; }
        set
        {
            if (name != null)
            {
                name = value;
            }
            else
            {
                Console.WriteLine("ERROR!");
                name = "Sanya";
            }
        }
    }

    public char Gender
    {
        get { return gender; }
        private set
        {
            if (value != 'M' || value != 'W')
            {
                Console.WriteLine("ERROR!");
                gender = 'M';
            }
            else
            {
                gender = value;
            }
        }
    }

    public int Course
    {
        set
        {
            if (value > 0 && value < 6)
            {
                this.course = value;
            }
            else
            {
                Console.WriteLine("ERROR!");
                course = 1;
            }
        }
    }
    
    //методы
    public void DeleteStudent()
    {
        if (course > 5)
        {
            Console.WriteLine(name + " отчислен");
        }
        else
        {
            Console.WriteLine(name + " не отчислен");
        }
    }
    
    //перегруженные методы
    public override string ToString()
    {
        string s = "Студент - " + name + ", " + course + " курс,";
        if (gender == 'M')
        {
            s += " муж";
        }
        else if (gender == 'W')
        {
            s += " жен";
        }
        else
        {
            s += " пол неизвестен";
        }

        return s;
    }
}