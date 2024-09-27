using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC21
{
    public class NumberController
    {
        static public int PowerOperation(int numBase, int numPow)
        {
            int result = numBase;
            for( int i = 1; i < numPow; i++)
            {
                result *= numBase;
            }
            return result;
        }
    }
}
