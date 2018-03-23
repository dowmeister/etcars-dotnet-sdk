using ETCarsDotNetSdk.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETCarsDotNetSdk.Events
{
    /// <summary>
    /// 
    /// </summary>
    public class ETCarsDisconnectedArgs : EventArgs
    {
        public ETCarsDisconnectedArgs()
        {
        }
    }

    public delegate void ETCarsDisconnectedEventArgs();
}
