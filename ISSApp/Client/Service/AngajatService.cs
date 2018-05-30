using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSApp.Domain;
using ISSApp.Exceptions;
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

        public AngajatCentru findByIdAccount(int id)
        {
            try
            {
                return _server.AngajatFindByIdAccount(id);

            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }

        public AngajatCentru findByUsername(string username)
        {
            try
            {
                return _server.AngajatFindByUsername(username);

            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }
    }
}
