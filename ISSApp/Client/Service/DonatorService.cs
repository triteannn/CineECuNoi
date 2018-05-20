using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSApp.Networking;

namespace Client.Service
{
    class DonatorService
    {
        private IServer _server;

        public DonatorService(IServer server)
        {

        }

        /*
         * verifica daca au trecut 3 luni de zile de la ultima donare
         */
        public bool poateDona(int idDonator)
        {
            DateTime ult = _server.AnalizaFindLastByDonator(idDonator).DataRecoltarii;

            if (DateTime.Today.Subtract(ult).TotalDays > 90)
            {
                return true;
            }

            return false;
        }
    }
}
