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
                throw new ServiceException(e.Message);
            }
        }

        public DataSet DonatorAdminGetDataSet()
        {
            try
            {
                return _server.DonatorAdminGetDataSet();
            }catch(NetworkingException e)
            {
                throw new ServiceException(e.Message);
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
                throw new ServiceException(e.Message);
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
                throw new ServiceException(e.Message);
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
                throw new ServiceException(e.Message);
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
                throw new ServiceException(e.Message);
            }
        }

        public int AngajatAdminUpdateDataBase(DataSet dataSet)
        {

            try
            {
                return _server.AngajatAdminUpdateDataBase(dataSet);
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public DataSet AngajatAdminGetDataSet()
        {
            try
            {
                return _server.AngajatAdminGetDataSet();
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public int CentruDonareAdminUpdateDataBase(DataSet dataSet)
        {

            try
            {
                return _server.CentruDonareAdminUpdateDataBase(dataSet);
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public DataSet CentruDonareAdminGetDataSet()
        {
            try
            {
                return _server.CentruDonareAdminGetDataSet();
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public int SpitalAdminUpdateDataBase(DataSet dataSet)
        {

            try
            {
                return _server.SpitalAdminUpdateDataBase(dataSet);
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public DataSet SpitalAdminGetDataSet()
        {
            try
            {
                return _server.SpitalAdminGetDataSet();
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public int DateContactAdminUpdateDataBase(DataSet dataSet)
        {

            try
            {
                return _server.DateContactAdminUpdateDataBase(dataSet);
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public DataSet DateContactAdminGetDataSet()
        {
            try
            {
                return _server.DateContactAdminGetDataSet();
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public int AdresaAdminUpdateDataBase(DataSet dataSet)
        {

            try
            {
                return _server.AdresaAdminUpdateDataBase(dataSet);
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public DataSet AdresaAdminGetDataSet()
        {
            try
            {
                return _server.AdresaAdminGetDataSet();
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }
    }
}
