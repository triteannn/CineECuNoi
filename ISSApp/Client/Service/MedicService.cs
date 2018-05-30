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
    class MedicService
    {
        private IServer _server;

        public MedicService(IServer server)
        {
            _server = server;
        }

        public Medic findByIdAccount(int id)
        {
            try
            {
                return _server.MedicFindByIdAccount(id);

            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }

        public Medic findByUsername(string username)
        {
            try
            {
                return _server.MedicFindByUsername(username);

            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }
    }
}
