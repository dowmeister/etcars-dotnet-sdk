using ETCarsDotNetSdk.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETCarsDotNetSdk.Events
{
    /// <summary>
    /// 
    /// </summary>
    public class ETCarsDataReceivedArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public string RawData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rawData"></param>
        /// <param name="data"></param>
        public ETCarsDataReceivedArgs(string rawData, ETCarsData data)
        {
            this.RawData = rawData;
            this.Data = data;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    public delegate void ETCarsDataReceivedEventArgs(ETCarsDataReceivedArgs args);
}
