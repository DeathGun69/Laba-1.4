    
using System;
using System.Collections.Generic;

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