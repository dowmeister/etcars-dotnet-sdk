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
        private List<string> dataPoints = new List<string>();
        private ClientSocket client = null;

        public bool IsConnected
        {
            get
            {
                return client == null ? false : client.IsConnected;
            }
        }

        public event ETCarsDataReceivedEventArgs DataReceived;

        public event ETCarsDisconnectedEventArgs Disconnected;

        public event ETCarsConnectedEventArgs Connected;

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
                client = new ClientSocket();
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
            Connected?.Invoke();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private void Client_Disconnected(Sockets.EventArgs.SocketDisconnectedArgs args)
        {
            Disconnected?.Invoke();
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
                if (data.Contains("{"))
                {
                    string startingData = data.Substring(data.IndexOf("{"));
                    dataPoints.Add(startingData);
                }
                else
                {
                    return;
                }
            }
            else
            {
                dataPoints.Add(data);
            }

            if (data.Contains("\r"))
            {
                string json = String.Join("", dataPoints.ToArray());
                dataPoints.Clear();
                
                int index = json.IndexOf("\r");
                json = json.Substring(0, index);
                
                try
                {
                    ETCarsDataContainer deserializedData = JsonConvert.DeserializeObject<ETCarsDataContainer>(json);

                    DataReceived?.Invoke(new ETCarsDataReceivedArgs(json, deserializedData.data));
                }
                catch
                {
                    return;
                }
            }
        }

    }
}
