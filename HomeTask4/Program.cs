using System;

namespace HomeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Apple Apple = new Apple("A,B1,B2,B3,B6,B9,C,E,H,PP");
            Fruits Pineapple = new Fruits("A,B1,B2,B3,B6,B9,C,E,K");
            Fruits Lemon = new Fruits("A,B1,B2,B3,B4,B5,B6,C,E");

            CustomList<Fruits> fruitList = new CustomList<Fruits>();

            Apple Apple = new Apple("A,B1,B2,B3,B6,B9,C,E,H,PP");
            //fruitList.Add(Apple);




            Console.WriteLine("Vitamins of Fruits: \n" + "Apple:");
            foreach (Fruits apple in fruitList.GetArray())
            {
                Console.WriteLine(apple);
            }
            Console.WriteLine("Pineapple");
            foreach (Fruits pineapple in fruitList.GetArray())
            {
                fruitList.Add(Pineapple);
                Console.WriteLine(pineapple);

            }
            Console.WriteLine("Lemon:");
            foreach (Fruits lemon in fruitList.GetArray())
            {
                fruitList.Add(Lemon);
                Console.WriteLine(lemon);
            }













        }
    }
}
