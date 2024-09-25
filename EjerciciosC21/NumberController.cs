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
            int result = 1;
            for( int i = 1; i <= numPow; i++)
            {
                result *= numPow;
            }
            return result;
        }
    }
}
