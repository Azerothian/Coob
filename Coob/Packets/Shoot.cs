﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coob.Packets
{
    public partial class Packet
    {
        public class Shoot : Base
        {
            public Shoot(Client client)
                : base(client)
            {
            }

            public override bool CallScript()
            {
                throw new NotImplementedException();
               // return (bool)Root.JavaScript.Engine.CallFunction("onShoot", this, Sender);
            }

            public override void Process()
            {
               throw new NotImplementedException();
            }

            public static Base Parse(Client client)
            {
                // TODO
                return new Shoot(client);
            }
        }
    }
}
