using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolee;

public class AlgorithQue1
{
    
    public string SumCalculator(string Value1,string Value2)
    {

			int value1Length = Value1.Length;
			int value2Length = Value2.Length;
			string sum="";
			int kalan = 0;
			if (value1Length > value2Length)
				Value2 = new string('0', value1Length - value2Length) + Value2;
			else if (value2Length > value1Length)
				Value1 = new string('0', value2Length - value1Length) + Value1;
			else if (value1Length == value2Length) {}
			else
				throw new Exception("Bir Sorun Oluştu");
			

            for (int i = Value1.Length-1; i >=0; i--)
			{
				int valu1Value = int.Parse(Value1[i].ToString());
				int valu2Value = int.Parse(Value2[i].ToString());
				int tempSum = valu1Value + valu2Value +kalan;
				if (tempSum >= 10&&i is not 0)
				{
					kalan = 1;
					sum =(tempSum - 10)+sum ;
				}
				else if (tempSum < 10&&i is not 0)
				{
					sum =  (tempSum)+ sum ;
					kalan = 0;
				}

                else if (i is 0)
                {
					sum = tempSum+sum ;
                }
                else
					throw new Exception("Bir Sorun Var");


			}
			return sum;
        
    }
}
