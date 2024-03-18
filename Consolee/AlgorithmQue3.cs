using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Consolee;

public static class AlgorithmQue3
{
    public static List<BigInteger> Calculator(string value1, string value2,double powValue)
    {
        List<BigInteger> bigIntegers = new ();
        BigInteger value1Value= BigInteger.Parse(value1);
        BigInteger value2Value = BigInteger.Parse(value2);

        if(value1Value>value2Value)
        {
            for (BigInteger i = value1Value; i >= value2Value; i--)
            {
                for (double j = powValue; j < 0; j--)
                {
                    i *= i;
                }
                bigIntegers.Add(i); 
            }
        }
        else if(value2Value>value1Value)
        {
            for (BigInteger i = value2Value; i >= value1Value; i--)
            {
                BigInteger bigInteger = i;
                for (double j = powValue; j > 0; j--)
                {
                    bigInteger *= bigInteger;
                }
                bigIntegers.Add(bigInteger);
            }
        }
        

        
        return bigIntegers;
    }
    public static List<BigInteger> Calculator2(BigInteger value1, BigInteger value2)
    {
        List<BigInteger> bigIntegers = new ();
        //BigInteger value1Value = BigInteger.Parse(value1);
        //BigInteger value2Value = BigInteger.Parse(value2);
        bigIntegers.Add(value1);
        bigIntegers.Add(value2);
        Console.WriteLine(bigIntegers.Count);
        return bigIntegers;
    }
}
