using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSApp.Networking;

namespace Client.Service
{
    class MedicService
    {
        private IServer _server;

        public MedicService(IServer server)
        {
            _server = server;
        }
    }
}
