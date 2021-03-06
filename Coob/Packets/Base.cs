﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coob.Packets
{
    public partial class Packet
    {
        public abstract class Base
        {
            public Client Sender;

            public Base(Client client)
            {
                Sender = client;
            }

            public string PacketTypeName
            {
                get
                {
                    return this.GetType().Name;
                }
            }

            public abstract bool CallScript();
            public abstract void Process();
        }
    }
}
