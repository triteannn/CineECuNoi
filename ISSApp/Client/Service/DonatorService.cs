﻿using ISSApp.Exceptions;
using ISSApp.Networking;
using System;

namespace Client.Service
{
    public class DonatorService
    {
        private IServer _server;

        public DonatorService(IServer server)
        {
            _server = server;
        }

        /*
         * verifica daca au trecut 3 luni de zile de la ultima donare
         */
        public bool poateDona(int idDonator)
        {

            try
            {
                DateTime ult = _server.AnalizaFindLastByDonator(idDonator).DataRecoltarii;

                if (DateTime.Today.Subtract(ult).TotalDays > 90)
                {
                    return true;
                }

                return false;
            } catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }
    }
}
