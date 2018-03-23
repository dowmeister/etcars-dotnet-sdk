using ETCarsDotNetSdk.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETCarsDotNetSdk.Events
{
    /// <summary>
    /// 
    /// </summary>
    public class ETCarsConnectedArgs : EventArgs
    {
        public ETCarsConnectedArgs()
        {
        }
    }

    public delegate void ETCarsConnectedEventArgs();
}
