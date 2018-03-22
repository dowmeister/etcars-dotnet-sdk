using ETCarsDotNetSdk.Entities;
using ETCarsDotNetSdk.Events;
using Newtonsoft.Json;
using Sockets;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ETCarsDotNetSdk
{
    /// <summary>
    /// 
    /// </summary>
    public class ETCarsClient
    {
        List<string> dataPoints = new List<string>();

        public event ETCarsDataReceivedEventArgs DataReceived;

        /// <summary>
        /// 
        /// </summary>
        public ETCarsClient()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        public void Connect(string host = "localhost", int port = 30001)
        {
            try
            {
                ClientSocket client = new ClientSocket();
                client.DataReceived += Client_DataReceived;
                client.Disconnected += Client_Disconnected;
                client.Connected += Client_Connected;
                client.Accept(new TcpClient(host, port));
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private void Client_Connected(Sockets.EventArgs.SocketConnectedArgs args)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private void Client_Disconnected(Sockets.EventArgs.SocketDisconnectedArgs args)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private void Client_DataReceived(Sockets.EventArgs.DataReceivedArgs args)
        {
            string data = Encoding.UTF8.GetString(args.Data);

            if (dataPoints.Count == 0)
            {
                string startingData = data.Substring(data.IndexOf("{"));
                dataPoints.Add(startingData);
            }
            else
                dataPoints.Add(data);

            if (data.Contains("\r"))
            {
                string json = String.Join("", dataPoints.ToArray());
                dataPoints.Clear();

                ETCarsDataContainer deserializedData = JsonConvert.DeserializeObject<ETCarsDataContainer>(json);

                DataReceived?.Invoke(new ETCarsDataReceivedArgs(json, deserializedData.data));
            }
        }

    }
}
