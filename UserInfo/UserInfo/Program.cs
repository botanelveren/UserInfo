using System;

namespace UserInfo
{
    class Program
     {
        static void Main(string[] args)
        {
            string informUser = "Lütfen aşağıdaki bilgileri giriniz:";
            string id = "T.C. Kimlik No:";
            string name = "Adı:";
            string lastName = "Soyadı:";
            string phoneNumber = "Telefon Numarası:"; 
            string age = "Yaş:";
            string firstProduct = "İlk Aldığı Ürünün Fiyatı:"; 
            string secondProduct = "İkinci Aldığı Ürünün Fiyatı:";
            string dashLine = "---------------------------------";

            Console.WriteLine(informUser);
            Console.Write(id);
            string idValue = Console.ReadLine();
            Console.Write(name);
            string nameValue = Console.ReadLine();
            Console.Write(lastName);
            string lastNameValue = Console.ReadLine();
            Console.Write(phoneNumber);
            string phoneNumberValue = Console.ReadLine(); // variable is defined as string because there isn't any numerical calculations related.
            Console.Write(age);
            Console.ReadLine();
            Console.Write(firstProduct);
            string firstProductValue = Console.ReadLine(); // variables "firstProduct" and "secondProduct" defined as string first to use with "Console.Readline" command.*Later on it will be converted to int for numerical calculations.
            Console.Write(secondProduct);
            string secondProductValue = Console.ReadLine();
    
            
            int.TryParse(firstProductValue, out int intFirstProductValue); // *Here string variables parsed into integer. 
            int.TryParse(secondProductValue, out int intSecondProductValue);   
            int sum = intFirstProductValue + intSecondProductValue;
            int point = sum * 10 / 100;
          

            Console.WriteLine($"{dashLine}\n" +
                $"{idValue} TC numaralı {nameValue} {lastNameValue} isimli kişi için kayıt oluşturulmuştur.\n" +
                $"{phoneNumberValue} telefon numarasına bildirim mesajı gönderilmiştir.\n" +
                $"{sum} toplam harcama karşılığı kazanılan 10% patika puan miktarı -> {point} TL'dir." );

        }
    }
}