﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsterSharp.Manager.Event
{
    public class ConfbridgeTalkingEvent : AbstractConfbridgeEvent
    {
        /// <summary>
        /// 
        /// </summary>
        public string TalkingStatus { get; set; }

        public ConfbridgeTalkingEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
