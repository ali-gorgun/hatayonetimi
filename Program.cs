using System;

namespace hata_yonetimi 
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                Console.WriteLine("bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmis oldugunuz sayi"+ sayi);  
            }
            catch(Exception ex)
            {
                Console.WriteLine("hata:"+ ex.Message.ToString());
            }
            // Optıonal
            // finally
            // {
            //  Console.Write("islem tamamlandi.");
            // }   

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {              
                Console.WriteLine("bos deger girdiniz");
                Console.WriteLine(ex);                  
            }
            catch(FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);  
            }
            catch(OverflowException ex)
            {
              Console.WriteLine("cok kucuk yada cok buyuk bir deger girdiniz");
                Console.WriteLine(ex);    
            } 
            finally{
                Console.WriteLine("islem basariyla tamamlandi");
            }
        }
    }
}
 // alı gorgun.