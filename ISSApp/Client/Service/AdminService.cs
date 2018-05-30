using ISSApp.Exceptions;
using ISSApp.Networking;
using System.Data;

namespace Client.Service
{
    public class AdminService
    {
        private IServer _server;

        public AdminService(IServer server)
        {
            _server = server;
        }

        public int DonatorAdminUpdateDataBase(DataSet dataSet)
        {

            try
            {
                return _server.DonatorAdminUpdateDataBase(dataSet);
            } catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }
    }
}
