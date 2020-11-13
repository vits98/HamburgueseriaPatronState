using System;
using System.Collections.Generic;
using System.Text;

namespace HamburgueseriaState
{
    public class GrillerStartState : IGrillState
    {
        public void handelMachine(Griller grillerContext)
        {
            Console.WriteLine("{0}: starting to grill the meat", nameof(GrillerStartState));
            grillerContext.GrillerState = new GrillingState();
            grillerContext.GrillerState.handelMachine(grillerContext);
        }
    }
}
