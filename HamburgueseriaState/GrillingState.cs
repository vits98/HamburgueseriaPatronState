using System;
using System.Collections.Generic;
using System.Text;

namespace HamburgueseriaState
{
    public class GrillingState : IGrillState
    {
        public void handelMachine(Griller grillerContext)
        {
            Console.WriteLine("{0}: grilling the meat:", nameof(GrillingState));
            grillerContext.GrillerState = new GrillEndState();
            grillerContext.GrillerState.handelMachine(grillerContext);
        }
    }
}
