﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsterSharp.Manager.Event
{
    public class BridgeDestroyEvent : BridgeStateEvent
    {
        public BridgeDestroyEvent(ManagerConnection source) : base(source)
        {
        }
    }
}
