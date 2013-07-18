using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coob.Packets
{
    public partial class Packet
    {
        public class Hit : Base
        {
            public enum HitType
            {
                Normal= 0,
                Block = 1,
                Miss = 3,
                Absorb = 5
            }
            public Hit(Client client)
                : base(client)
            {
            }

            public override bool CallScript()
            {
                throw new NotImplementedException();
                
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
