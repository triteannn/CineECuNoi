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

        public DataSet DonatorAdminGetDataSet()
        {
            try
            {
                return _server.DonatorAdminGetDataSet();
            }catch(NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }

        public int AccountAdminUpdateDataBase(DataSet dataSet)
        {

            try
            {
                return _server.AccountAdminUpdateDataBase(dataSet);
            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }

        public DataSet AccountAdminGetDataSet()
        {
            try
            {
                return _server.AccountAdminGetDataSet();
            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }

        public int MedicAdminUpdateDataBase(DataSet dataSet)
        {

            try
            {
                return _server.MedicAdminUpdateDataBase(dataSet);
            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }

        public DataSet MedicAdminGetDataSet()
        {
            try
            {
                return _server.MedicAdminGetDataSet();
            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }
    }
}
