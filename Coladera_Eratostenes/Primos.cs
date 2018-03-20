using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera_Eratostenes
{
    static class Primos
    {
        public static String getEnterosPrimos(int limite)
        {
            int[] vector = new int[limite];
            String result = "";
            for (int i = 1; i < limite; i++)
            {
                vector[i] = 1;
            }

            for (int i = 2; i < limite; i++)
            {
                for (int j = i+1; j < limite; j++)
                {
                    if(j % i == 0)
                    {
                        vector[j] = 0;
                    }
                }
            }

            for (int i = 1; i < limite; i++)
            {
                if (vector[i] == 1)
                {
                    result += i + ",";
                }
            }

            return result;

        }
    }
}
