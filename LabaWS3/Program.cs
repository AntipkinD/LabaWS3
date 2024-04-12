internal class Program
{
    struct Student
    {
        string Surname;
        string Initials;
        string Numofgroup;
        int[] Grades;

        public Student(string surname, string inits, string numofgroup, params int[] grades)
        {
            this.Surname = surname;
            this.Initials = inits;
            this.Numofgroup = numofgroup;
            this.Grades = grades;
        }
        public Student()
        {
            this.Surname = "Undefined";
            this.Initials = "Undefined";
            this.Numofgroup = "Undefined";
            this.Grades = new int[] { 0, 0, 0, 0, 0 };
        }
        public double GradeAverage(params int[] grades)
        {
            return grades.Average();
        }
        private static void Main(string[] args)
        {
            Student[] studs = new Student[7]
            {
                new Student("Елизаров", "М.Ю.", "22ИТ35", 5, 5, 5, 5, 5),
                new Student("Лисичников", "А.А.", "22ИТ35", 1, 2, 1, 2, 1),
                new Student("Тупицин", "И.А.", "22ИТ35", 2, 1, 2, 1, 2),
                new Student("Цомкалов", "И.О.", "22ИТ35", 2, 2, 2, 2, 2),
                new Student(),
                new Student("Грацкий", "Ю.И.", "22ИТ35", 5, 4, 3, 2, 1),
                new Student("Испанских", "Т.П.", "22ИТ35", 5, 4, 3, 4, 5),
            };
            Student temp;
            for (int i = 0; i <= studs.Length - 1 ; i++)
            {
                for (int j = i + 1; j < studs.Length; j++)
                {
                    if (studs[i].GradeAverage(studs[i].Grades) > studs[j].GradeAverage(studs[j].Grades))
                    {
                        temp = studs[i];
                        studs[i] = studs[j];
                        studs[j] = temp;
                    }
                }
            }
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine($"{studs[i].Surname}, {studs[i].Initials}, {studs[i].Numofgroup}, {studs[i].GradeAverage(studs[i].Grades)}");
            }
        }
    }
}