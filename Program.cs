using System;

namespace ValueAndReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //int,decimal,float,bool,double --------Value Type(Deger Tip)

            //Array,Class,Interface -------Referance Type


            int Num1 = 10;
            int Num2 = 30;
            Num1 = Num2;
            Num2 = 65;

            Console.WriteLine(Num1);


            int[] Numbers = new int[] { 10, 20, 30 };
            int[] Numbers2 = new int[] { 100, 200, 300 };
            Numbers = Numbers2;
            Numbers2[0] = 999;

            Console.WriteLine(Numbers[0]);




        }
    }
}
