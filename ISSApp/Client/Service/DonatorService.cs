using ISSApp.Domain;
using ISSApp.Exceptions;
using ISSApp.Networking;
using System;
using System.Collections.Generic;

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
                throw new ServiceException(e.Message);
            }
        }

        public Donator findByIdAccount(int id)
        {
            try
            {
                return _server.DonatorFindByIdAccount(id);

            } catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public Donator findByUsername(string username)
        {
            try
            {
                return _server.DonatorFindByUsername(username);

            } catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void SubmitFormularDonare(FormularDonare formularDonare)
        {
            try
            {
                _server.FormularDonareAdd(formularDonare);
            } catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<Analiza> AnalizaFindByDonator(int idDonator)
        {
            try
            {
                return _server.AnalizaFindByDonator(idDonator);
            } catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public bool NevoieSangeCentru(int idDonator)
        {
            try
            {
                int? idCd = _server.DonatorFindEntity(idDonator).IdCd;
                if (idCd != null)
                    if (_server.CentruDonareFindEntity((int)idCd).NeedBlood == 1)
                        return true;
                return false;
            } catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }
    }
}
