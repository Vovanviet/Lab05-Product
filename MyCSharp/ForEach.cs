using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp
{
     class ForEach
    {
        public void Main(string[] args) {
            DateTime now = DateTime.Now;
            Random random = new Random((int)now.Millisecond);
            int[] Arr= new int[10];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i]=random.Next()%10;

            }
            int Total = 0;
            Console.Write("Array values are");
            foreach (int i in Arr)
            {
                Total += i;
                Console.Write(i + ", ");
            }
            Console.WriteLine("\nAnd the average is {0,0:F1}",(double)Total/(double)Arr.Length);
            Console.ReadLine();
        }
        
    }
}
