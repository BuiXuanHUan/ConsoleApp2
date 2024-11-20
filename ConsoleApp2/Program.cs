using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    
    class Student
    {
        public int Id { get; set; }    
        public string Name { get; set; }   
        public int Age { get; set; }   
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, Name = "An", Age = 16 },
                new Student() { Id = 2, Name = "Binh", Age = 18 },
                new Student() { Id = 3, Name = "Chau", Age = 17 },
                new Student() { Id = 4, Name = "Anh", Age = 19 },
                new Student() { Id = 5, Name = "Dung", Age = 15 }
            };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("a. Danh sách toàn bộ học sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }
            Console.WriteLine();

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            Console.WriteLine("b. Danh sách học sinh có tuổi từ 15 đến 18:");
            var age15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in age15to18)
            {
                Console.WriteLine($"Id: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }
            Console.WriteLine();

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("c. Học sinh có tên bắt đầu bằng chữ 'A':");
            var namesStartingWithA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var student in namesStartingWithA)
            {
                Console.WriteLine($"Id: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }
            Console.WriteLine();

            // d. Tính tổng tuổi của tất cả học sinh
            Console.WriteLine("d. Tổng tuổi của tất cả học sinh:");
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tổng tuổi: {totalAge}");
            Console.WriteLine();

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            Console.WriteLine("e. Học sinh có tuổi lớn nhất:");
            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge);
            foreach (var student in oldestStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }
            Console.WriteLine();

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            Console.WriteLine("f. Danh sách học sinh sắp xếp theo tuổi tăng dần:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }
            Console.WriteLine();

            // Giữ màn hình console
            Console.WriteLine("Nhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}
