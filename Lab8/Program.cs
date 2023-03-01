namespace Lab8
{
    public class Program
    {
        static void Main(string[] args)
        {
            var students = File.ReadAllLines("students.csv")
                .Skip(1)
                .Select(line => {
                    var columns = line.Split(',');
                    return new Student
                    {
                        Name = columns[0],
                        Grade = int.Parse(columns[1]),
                        Age = int.Parse(columns[2])
                    };
                })
                .ToList();

            var filteredStudents = students.Where(student => student.Grade >= 70);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }
        }
    }
}