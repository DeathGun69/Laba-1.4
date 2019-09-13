using System;
using System.Collections.Generic;

namespace laba1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            foreach (var val in args){
                num.Add(Convert.ToInt32(val));
            }
            Summator sum_and_mult = new Summator(num);
            Console.WriteLine("Сумма введенных чисел: " + sum_and_mult.Sum_Num());
            Console.WriteLine("Произведение введенных чисел: " + sum_and_mult.Mult_Num());
        }
    }

    public class Summator {
        public List<int> Num = new List<int>();
        public Summator(List<int> numb) {
            Num = numb;
        }

        public int Sum_Num(){
            int Sum=0;
            foreach(var numb in Num) {
                Sum += numb;
            }
            return Sum;
        }

        public int Mult_Num(){
            int Mult=1;
            foreach(var numb in Num) {
                Mult *= numb;
            }
            return Mult;
        }

    }
}
