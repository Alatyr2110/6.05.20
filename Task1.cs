using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    //Тарануха Яна
    //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
    //Продемонстрировать работу структуры;
    //б) Дописать класс Complex, добавив методы вычитания и 
    //произведения чисел.Проверить работу класса;
    partial class Homework3
    {
        //
        public static void Task1()
        {
            Console.WriteLine("Не работает. Ничего, кроме этого не видит, здесь присутствует Main. В отдельном файле работает.");
            Console.ReadKey();
        }//??? Почему просит закрыть?
        /*struct Complex
        {
            public double re;
            public double im;

            public Complex Plus(Complex x)//сложение
            {
                Complex y;
                y.re = re + x.re;
                y.im = im + x.im;
                return y;
            }
            public string ToString1()
            {
                return re + "+" + im + "i"; //когда im<0, как выводить?
            }
            public Complex Multi(Complex x) //произведение
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public string ToString2()
            {
                return re + "+" + im + "i";
            }
            public Complex Subtr(Complex x)//вычитание
            {
                Complex y;
                y.re = re - x.re;
                y.im = im - x.im;
                return y;
            }
            public string ToString3()
            {
                return re + "+" + im + "i";
            }
            public Complex Segm(Complex x) //деление
            {
                Complex y;
                y.im = (im * x.re - re * x.im) / (x.re * x.re + x.im * x.im); //re * x.im + im * x.re;
                y.re = (re * x.re + im * x.im) / (x.re * x.re + x.im * x.im); //re * x.re - im * x.im;
                return y;
            }
            public string ToString4()
            {
                return re + "+" + im + "i";
            }
            public static void Main() //???????
            {
                Complex complex1;
                complex1.re = 1;
                complex1.im = 1;

                Complex complex2;
                complex2.re = 2;
                complex2.im = 2;

                Complex result = complex1.Plus(complex2);
                Console.WriteLine(result.ToString1());

                result = complex1.Multi(complex2);
                Console.WriteLine(result.ToString2());

                result = complex1.Segm(complex2);
                Console.WriteLine(result.ToString3());

                result = complex1.Segm(complex2);
                Console.WriteLine(result.ToString4());

                _ = Console.ReadKey();
            }
        }*/

    }
}
