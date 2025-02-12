namespace AsterSharp.Manager.Event
{
    /// <summary>
    ///     A ConnectEvent is triggered after successful login to the asterisk server.<br />
    ///     It is a pseudo event not directly related to an asterisk generated event.
    /// </summary>
    public class ConnectEvent : ConnectionStateEvent
    {
        public ConnectEvent(ManagerConnection source)
            : base(source)
        {
        }

        /// <summary>
        ///     Get/Set the version of the protocol.
        /// </summary>
        public string ProtocolIdentifier { get; set; }
    }
}