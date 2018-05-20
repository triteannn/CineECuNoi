using System;
using ISSApp.Domain;
using ISSApp.Networking;

namespace ISSApp.Service
{
    public class ServicePungaSange : IService
    {
        private readonly IServer _server;
        public ServicePungaSange(IServer server)
        {
            _server = server;
        }

        /*
         * Inregistrarea unei pungi de sange, in momentul recolarii.
         * Targetul poate fi un string sau stringul null (caz in care in BD o sa fie NULL)
         */
        void addPungaSange(DateTime DataRecoltare, string Target, int IdCd, int IdFd)
        {
            PungaSange ps;
            if (Target != "")
            {
                ps = new PungaSange(DataRecoltare,Target, IdCd, IdFd);
            }
            else
            {
                ps = new PungaSange(DataRecoltare, IdCd, IdFd);
            }

            _server.PungaSangeAdd(ps);
        }

    }
}