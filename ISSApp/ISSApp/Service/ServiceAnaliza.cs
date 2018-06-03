using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSApp.Domain;
using ISSApp.Networking;

namespace ISSApp.Service
{
    class ServiceAnaliza : IService
    {
        private readonly IServer _server;

        public ServiceAnaliza(IServer server)
        {
            _server = server;
        }

    }
}
