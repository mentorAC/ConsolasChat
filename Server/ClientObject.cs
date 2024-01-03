using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ClientObject
    {
        private readonly TcpClient client;
        private readonly Server server;

        private string Id { get; } = Guid.NewGuid().ToString();
        private StreamReader Reader { get; }
        public ClientObject(TcpClient client, Server server)
        {
            this.client = client;
            this.server = server;

            var stream = client.GetStream();

            Reader = new StreamReader(stream);

        }


        public void ProcessAsync()
        {

        }
    }
}
