
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlysinhvienbanglinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { id = "1", name = "Alice", age = 16 },
                new Student { id = "2", name = "Bob", age = 18 },
                new Student { id = "3", name = "Charlie", age = 15 },
                new Student { id = "4", name = "David", age = 17 },
                new Student { id = "5", name = "Eva", age = 20 }
             };
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Hien thi toan bo danh sach");
                Console.WriteLine("2. Hoc sinh tu 15 den 18 tuoi");
                Console.WriteLine("3. hoc sinh co ten bat dau bang chu A");
                Console.WriteLine("4. Tong tuoi cua ca danh sach");
                Console.WriteLine("5. hoc sinh co tuoi lon nhat");
                Console.WriteLine("6. sap xep danh sach theo tuoi");
                Console.WriteLine("0. Thoat");

                Console.Write("Nhap lua chon: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Hiển thị danh sách học sinh
                        ShowListStudent(students);
                        break;
                    case 2:
                        // Tìm học sinh theo tuổi
                        SeachAge(students);
                        break;
                    case 3:
                        // Tìm học sinh theo tên
                        SeachName(students);
                        break;
                    case 4:
                        // Tính tổng tuổi
                        SumAge(students);
                        break;
                    case 5:
                        // Học sinh có tuổi lớn nhất
                        SeachMaxAge(students);
                        break;
                    case 6:
                        // Sắp xếp danh sách theo tuổi
                        SortStudent(students);
                        break;
                    case 0:
                        Console.WriteLine("ket thuc!");
                        exit = true;
                        return;
                    default:
                        Console.WriteLine("Vui long chon lai.");
                        break;
                }
            }

        }

        // a. In danh sách toàn bộ học sinh
        public static void ShowListStudent(List<Student> students)
        {
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                student.Show();
            }
        }

        // b. Tìm và in ra danh sách học sinh có tuổi từ 15 đến 18
        public static void SeachAge(List<Student> students)
        {
            var age15to18 = students.Where(s => s.age >= 15 && s.age <= 18);
            Console.WriteLine("\nDanh sach hoc sinh co tuoi tu 15 den 18:");
            foreach (var student in age15to18)
            {
                student.Show();
            }
        }

        // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
        public static void SeachName(List<Student> students)
        {
            var nameStartsWithA = students.Where(s => s.name.StartsWith("A"));
            Console.WriteLine("\nDanh sach hoc sinh co ten bat dau chu 'A':");
            foreach (var student in nameStartsWithA)
            {
                student.Show();
            }
        }

        // d. Tính tổng tuổi của tất cả học sinh
        public static void SumAge(List<Student> students)
        {
            var totalAge = students.Sum(s => s.age);
            Console.WriteLine("\nTong tuoi cua hoc sinh: {0}", totalAge);
        }

        // e. Tìm và in ra học sinh có tuổi lớn nhất
        public static void SeachMaxAge(List<Student> students)
        {
            var maxAgeStudent = students.OrderByDescending(s => s.age).FirstOrDefault();
            Console.WriteLine("\nhoc sinh co tuoi lon nhat la: {0}  {1} tuổi", maxAgeStudent.name, maxAgeStudent.age);
        }

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần
        public static void SortStudent(List<Student> students)
        {
            var sortedStudents = students.OrderBy(s => s.age).ToList();
            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep:");
            foreach (var student in sortedStudents)
            {
                student.Show();
            }
        }
    }
}
