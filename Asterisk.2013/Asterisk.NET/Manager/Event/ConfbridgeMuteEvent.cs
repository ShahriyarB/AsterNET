﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsterSharp.Manager.Event
{
    public class ConfbridgeMuteEvent : AbstractConfbridgeEvent
    {
        public ConfbridgeMuteEvent(ManagerConnection source)
            : base(source)
        {
        }
    }
}
