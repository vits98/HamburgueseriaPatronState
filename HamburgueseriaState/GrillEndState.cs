using System;
using System.Collections.Generic;
using System.Text;

namespace HamburgueseriaState
{
    public class GrillEndState : IGrillState
    {
        public void handelMachine(Griller grillerContext)
        {
            Console.WriteLine("{0}: the meat es ready", nameof(GrillEndState));
            grillerContext.GrillerState = new ReadyState();
            grillerContext.GrillerState.handelMachine(grillerContext);
        }
    }
}
