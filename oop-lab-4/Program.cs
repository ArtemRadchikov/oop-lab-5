using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //нельзя создать жкземпляр абстрактного класса
            //Goods goodsExample=new Goods("Товар","РБ",23333);

            Technique headphones = new Headphones("Наушники","РБ",44444,"2 года",ConsoleColor.Blue);

            Technique tecniqueExample = new Technique("Товар", "РБ", 23333,"2 year");
            tecniqueExample.Print();
            Console.WriteLine(tecniqueExample.Manufacturer);
            Console.WriteLine(tecniqueExample.ToString());
            
            //Technique techniqueExample=new Technique("Техника","РБ",)
            stop();

            // Поработать с объектами через ссылки на абстрактные классы и интерфейсы
            IGoods igoodsExample = new Technique("Товар", "РБ", 23333, "2 year");
            Console.WriteLine(igoodsExample.Discount());
            stop();

            ICommonFunctionsForPhones icommonFunctionExample = new Smartphone("Sony", "China", 54_555, "2 year", 80_29_89_47_333, true);
            icommonFunctionExample.Call();

            stop();

            Goods PhoneExample = new Smartphone("Sony", "China", 54_555, "2 year", 80_29_89_47_333, true);
            PhoneExample.Print();

            stop();

            ((Smartphone)PhoneExample).Call();
            stop();

            ((ICommonFunctionsForPhones)PhoneExample).Call();
            stop();

            ((ICommonFunctionsForSmartphones)PhoneExample).Call();
            Console.WriteLine(PhoneExample.ToString());
            stop();




            Printer printer = new Printer();
            Goods[] array = { tecniqueExample, PhoneExample, headphones };

            stop();
            for (int i = 0; i < array.Length; i++)
            {
                printer.IAmPrinting(array[i]);
            }

            stop();
            if (PhoneExample is Technique)
            {
                tecniqueExample = PhoneExample as Technique;
                tecniqueExample.Print();
            }

            



            void stop()
            {
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
