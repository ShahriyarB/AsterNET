﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsterSharp.Manager.Event
{
    /// <summary>
    ///     Raised as part of the ConfbridgeListRooms action response list.<br/>
    ///     See <see target="_blank"  href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+16+ManagerEvent_ConfbridgeList">https://wiki.asterisk.org/wiki/display/AST/Asterisk+16+ManagerEvent_ConfbridgeList</see>
    /// </summary>
    public class ConfbridgeListRoomsEvent : AbstractConfbridgeEvent
    {
        /// <summary>
        ///     Gets or sets the parties.
        /// </summary>
        public int Parties { get; set; }

        /// <summary>
        ///     Gets or sets the marked.
        /// </summary>
        public int Marked { get; set; }

        /// <summary>
        ///     Gets or sets the locked.
        /// </summary>
        public string Locked { get; set; }

        /// <summary>
        ///     Creates a new <see cref="ConfbridgeListRoomsEvent"/>.
        /// </summary>
        /// <param name="source"><see cref="ManagerConnection"/></param>
        public ConfbridgeListRoomsEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
