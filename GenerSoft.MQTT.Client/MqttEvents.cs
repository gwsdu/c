﻿using MQTTnet;
using MQTTnet.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerSoft.MQTT.Client
{
    public class MqttMessageNotifyEventArgs : EventArgs
    {
        public bool IsConnect { get; set; }

        public string ClientId { get; set; }

        public MqttApplicationMessage MqttApplicationMessage { get; set; }

        public MqttMessageNotifyEventArgs(bool isConnect, string clientId, MqttApplicationMessage mqttApplicationMessage)
        {
            MqttApplicationMessage = mqttApplicationMessage;
            IsConnect = isConnect;
            ClientId = clientId;

        }
       
    }


    public class MqttConnectNotifyEventArgs : EventArgs
    {
        public bool IsConnect { get; set; }

        public MqttConnectNotifyEventArgs(bool isConnect)
        {

            IsConnect = isConnect;

        }
    }
}
