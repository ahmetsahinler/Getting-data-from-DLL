using TxtDataRead;
namespace Program
{
    class CarRace
    {
        public static void Main(string[] args)  
        {
            double toplam = 0 , toplam2 =0 ,tasıyıcı = 0,tasıyıcı2 = 0;
            int sayac = 0 ,sayac2 =0;
            string best="" , best2 ="";

            foreach (var carInfo in BanaVeriGetir.Getir("C:\\Users\\Ahmet\\Desktop\\Ahmet\\Odev7\\bin\\car_data.txt"))
            {
                if (carInfo.Purchased > 0 && carInfo.Gender == "Female")
                {
                    toplam += carInfo.Age;
                    sayac++;   
                }
                if (carInfo.Purchased > 0 && carInfo.Gender == "Male")
                {
                    toplam2 += carInfo.Age;
                    sayac2++;
                }
                if (carInfo.AnnualSalary > tasıyıcı && carInfo.Gender == "Female")
                {
                    tasıyıcı=carInfo.AnnualSalary;
                    best= "Yıllık geliri en yüksek olan kadının User_ID'si: "+carInfo.User_ID+" yaşı: "+carInfo.Age+" geliri: "+carInfo.AnnualSalary;
                }
                if (carInfo.AnnualSalary > tasıyıcı && carInfo.Gender == "Male")
                {
                    tasıyıcı2=carInfo.AnnualSalary;
                    best2= "Yıllık geliri en yüksek olan erkeğin User_ID'si: "+carInfo.User_ID+" yaşı: "+carInfo.Age+" geliri: "+carInfo.AnnualSalary;
                }
            }

            Console.WriteLine("Araba satın almış(alan) kadınların yaş ortalaması: " + toplam / sayac);
            Console.WriteLine("Araba satın almış(alan) erkeklerin yaş ortalaması: " + toplam2 / sayac2);
            Console.WriteLine(best);
            Console.WriteLine(best2);
            Console.ReadLine();



        }
    }

}