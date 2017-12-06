using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class MediaInventory
    {
        public delegate bool TestMedia();

        public void TestResult(TestMedia mediaDelegate){
            if(mediaDelegate() == true)
            {
                Console.WriteLine("Works. Add to Inventory.");
            }
            else
            {
                Console.WriteLine("Media Failed.");
            }
        }
    }
}
