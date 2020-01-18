using ETCarsDotNetSdk.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETCarsDotNetSdk.Events
{
    /// <summary>
    /// 
    /// </summary>
    public class ETCarsConnectionFailedArgs : EventArgs
    {

        /// <summary>
        /// 
        /// </summary>
        public Exception Exception { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        public ETCarsConnectionFailedArgs(Exception exception)
        {
            this.Exception = exception;
        }
    }

    public delegate void ETCarsConnectionFailedEventArgs(ETCarsConnectionFailedArgs args);
}