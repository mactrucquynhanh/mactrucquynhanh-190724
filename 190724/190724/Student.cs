using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlysinhvienbanglinq
{
    internal class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public Student()
        {
        }
        public Student(string studentID, string fullName, int averageScore)
        {
            this.id = studentID;
            this.name = fullName;
            this.age = averageScore;
        }
        //4. Methods
        public void Input()
        {
            Console.Write("Nhap ID:");
            this.id = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien:");
            this.name = Console.ReadLine();
            Console.Write("Nhap Tuoi:");
            this.age = int.Parse(Console.ReadLine()); //ép sang kiểu float

        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0} Ho Ten:{1} tuoi:{2}",
            this.id, this.name, this.age);
        }
    }
}


