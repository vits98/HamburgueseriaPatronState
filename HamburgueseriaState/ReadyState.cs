using System;
using System.Collections.Generic;
using System.Text;

namespace HamburgueseriaState
{
    public class ReadyState: IGrillState
    {
        public void handelMachine(Griller grillerContext)
        {
            Console.WriteLine("The griller is ready to use");
        }
    }
}
