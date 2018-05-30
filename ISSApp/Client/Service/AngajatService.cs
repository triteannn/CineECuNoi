using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSApp.Networking;

namespace Client.Service
{
    class AngajatService
    {
        private IServer _server;

        public AngajatService(IServer server)
        {
            _server = server;
        }
    }
}
