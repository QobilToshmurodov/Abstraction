using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {

        // 1-Topshiriq:
        /* Quyidagi Human klassini abstract qilib belgilang.  Pastroqdagi Main() metodiga tushib,
         * u yerda Human klassiga mansub bo'lgan oz'garuvchini e'lon qilinish joyida ro'y bergan 
         * xatoga e'tibor bering. Bu xato nima uchun ro'y bergani haqida fikr qiling. Sababini tushuning.*/

        // 2-Topshiriq:
        /* Human klassida abstract bo'lgan Sleep(int hours) metodini e'lon qiling. Dasturni
         * kompilyatsiya qiling. Qanday xato ro'y berdi? Employee klassida Sleep() metodini 
         * override qilib, uning badanida konsolga "Men {hours} soat uxlayman" degan matn chiqaring.*/

        //  3-Topshiriq:
        /* Main metodida Employee klassiga mansub bo'lgan o'zgaruvchining Sleep() metodini chaqiring. Natijani kuzating.*/

        public class Employee : Human
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
            public string Position { get; set; }
            public override void Sleep(int hours)
            {
                Console.WriteLine($"Men {hours} soat uxlayman");
            }

            public override void Speak()
            {
                Console.WriteLine("Men hodimman!");
            }
        }

        public abstract class Human
        {
            private int id;
            private byte gender;
            private readonly DateTime dateOfBirth;

            public abstract void Sleep(int hours);
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public byte Gender
            {
                get { return gender; }
                set { gender = value; }
            }
            //public DateTime DateOfBirth
            //{
            //    get { return dateOfBirth; }
            //    init { dateOfBirth = value; }
            //}
            public virtual void Speak()
            {
                Console.WriteLine("Men odamman!");
            }
        
            static void Main(string[] args)
            {
                var employee = new Employee();
                employee.Speak();
                employee.Sleep(4);
            }
            }
    }
}
