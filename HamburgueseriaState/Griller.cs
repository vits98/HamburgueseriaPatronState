using System;
using System.Collections.Generic;
using System.Text;

namespace HamburgueseriaState
{
    public class Griller
    {
        private IGrillState _grillerState;

        public Griller()
        {
            _grillerState = new ReadyState();
        }
        public IGrillState GrillerState
        {
            get
            {
                return _grillerState;
            }
            set
            {
                _grillerState = value;
            }
        }

        public void Grill()
        {
            Console.WriteLine("grilling proces begins.");
            _grillerState = new GrillerStartState();
            _grillerState.handelMachine(this);
        }

    }
}
