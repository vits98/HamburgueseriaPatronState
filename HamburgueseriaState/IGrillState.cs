using System;
using System.Collections.Generic;
using System.Text;

namespace HamburgueseriaState
{
    public interface IGrillState
    {
        void handelMachine(Griller grillerContext);
    }
}
