using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Class
    {

        public IList<Student> students = new List<Student>();

        public void Add(Student ogrenci)
        {
            bool Varmı = false;
   
                foreach (var item1 in students)
                {

                    if (item1.Name == ogrenci.Name && item1.Surname == ogrenci.Surname)
                    {
                        Varmı = true;

                    }
                }
                if (Varmı)
                {
                    Console.WriteLine("Öğrenci sınıfa kayıtlı. Eklemeye devam etmek istiyor musunuz?(E/H)");
                    var sonuc = Console.ReadLine().ToUpper();
                    if (sonuc == "E")
                    {
                        students.Add(ogrenci);
                        Console.WriteLine("Ekleme işlemi gerçekleşmiştir....\n\n\n");
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci sınıfa eklenmedi.");
                    }
                }
                else
                {
                    students.Add(ogrenci);
                    Console.WriteLine("Ekleme işlemi gerçekleşmiştir....\n\n\n");
                }
          
        }

        public bool Control(int no)
        {
            bool kontrolno = false;
            foreach (var a in students)
            {
                if (a.No == no)
                    kontrolno = true;
            }
            return kontrolno;
        }

        public List<Student> GetStudentsByName(string name)
        {
            return students.Where(x =>x.Name.Contains(name)).ToList();
        }
        public List<Student> GetStudenttsByNo(int no)
        {
            return students.Where(x => x.No==no).ToList();
        }

        public Student GetStudent(int no)
        {
            return students.FirstOrDefault(x => x.No == no);
        }

        public List<Student> RemoveByNo(int no)
        {
            var silinecekogrenci = students.SingleOrDefault(x=>x.No==no);
            if (silinecekogrenci!=null)
            {
                students.Remove(silinecekogrenci);
                Console.WriteLine($"{silinecekogrenci.No} numaralı {silinecekogrenci.Name} {silinecekogrenci.Surname} isimli öğrenci silinmiştir.");
            }
            return students.ToList();
        }

        public void göster()
        {
            Console.WriteLine("No----Ad----Soyad");
            foreach (var item in students)
            {
                Console.WriteLine($"{item.No}-{item.Name}{item.Surname}");
            }
        }

    }
}
