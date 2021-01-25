using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            var StudentList = new Class();

            
            bool devamMı = false;
            try
            {
                while (!devamMı)
                {
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
                    Console.WriteLine("1:Öğrenci Ekleme\n2:Öğrenci Silme\n3:İsme Göre Öğrenci Arama\n4:Numaraya Göre Öğrenci Arama\n5:Öğrenci Listesi Görüntüleme");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            var student = new Student();

                            Console.WriteLine("Öğrencinin numarasını giriniz: ");
                            student.No = Convert.ToInt32(Console.ReadLine());
                            var sonuc=StudentList.Control(student.No);
                            if (sonuc)
                            {
                                Console.WriteLine($"{student.No} numaralı öğrenci sisteme kayıtlıdır..");
                            }
                            else
                            {
                                Console.WriteLine("Öğrencinin adını giriniz:");
                                student.Name = Console.ReadLine();

                                Console.WriteLine("Öğrencinin soyadını giriniz.");
                                student.Surname = Console.ReadLine();



                                StudentList.Add(student);
                            }
             
                            break;

                        case 2:
                            Console.WriteLine("Silmek istediğiniz öğrencinin numarasını giriniz.");
                            int silinecekNo = Convert.ToInt32(Console.ReadLine());
                            StudentList.RemoveByNo(silinecekNo);

                            break;

                        case 3:
                            Console.WriteLine("Aramak istediğiniz öğrencinin adını giriniz.");
                            var aramaAd =Console.ReadLine();
                          
                            if (StudentList.GetStudentsByName(aramaAd) != null)
                            {
                                Console.WriteLine($"{aramaAd} isimli öğrenci listede yer almaktadır.");
                            }
                            else
                            {
                                Console.WriteLine("Aradığınız öğrenci listede yer almamaktadır.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Aramak istediğiniz öğrencinin numarasını giriniz.");
                            var aramaNo = Convert.ToInt32(Console.ReadLine());                            
                            if (StudentList.GetStudenttsByNo(aramaNo) != null)
                            {
                                Console.WriteLine($"{aramaNo} numaralı öğrenci listede yer almaktadır.");
                            }
                            else
                            {
                                Console.WriteLine("Aradığınız öğrenci listede yer almamaktadır.");
                            }
                            break;
                        case 5:
                            Console.WriteLine("ÖĞRENCİ LİSTESİ");
                            StudentList.göster();
                            break;

                    }
                    devamMı = false;
                    Console.WriteLine("----------------------------------------------\n");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Hata ile karşılaşıldı\n.");
            }

            Console.ReadLine();
        }



    }
}
