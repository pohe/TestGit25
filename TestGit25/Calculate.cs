using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit25
{
    public class Calculate
    {
        //This is a comment
        public int Add(int t1, int t2)
        {
            return t1 + t2;
        }
        //test 
        public int Subtract(int t1, int t2)
        {
            return t1 - t2;
        }


        //endnu en test222


        //endnu en test


        public int Multiply(int t1, int t2)
        {
            return t1 * t2;
        }

        // der er nyt fra Feature A



        //Flere comments

        public int Divide(int t1, int t2)
        {
            if (t2==0)
            {
                throw new ArgumentException();
            }
            return t1 / t2;
        }


        public void PrintResult(int result)
        {
            Console.WriteLine( result );
        }

    }
}
