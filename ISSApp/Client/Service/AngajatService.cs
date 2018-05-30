using System;
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


        /*
         * ce se intampla cand campul cu targetul nu este completat in interfata !!!!!!!!!
         */
        public void addPungaSange(DateTime dataRecoltare, string target, int idCd, int idFd)
        {
            try
            {
                PungaSange punga = new PungaSange()
                {
                    DataRecoltare = dataRecoltare,
                    Target = target,
                    IdCd = idCd,
                    IdFd = idFd
                };

                _server.PungaSangeAdd(punga);
            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }       

        }

        public void impartirePungaSange(PungaSange pungaSange, float cantitatePlasma, float cantitateTrombocite, float cantitateGlobule)
        {
            DateTime expirarePlasma = pungaSange.DataRecoltare.AddMonths(12);
            DateTime expirareTrombocite = pungaSange.DataRecoltare.AddDays(5);
            DateTime expirareGlobule = pungaSange.DataRecoltare.AddDays(42);
            try
            {
                if (pungaSange.Target != null)
                {
                    _server.PlasmaAdd(new PSPlasma()
                    {
                        Cantitate = cantitatePlasma,
                        Target = pungaSange.Target,
                        DataExpirare = expirarePlasma,
                        Grupa = pungaSange.Grupa,
                        Rh = pungaSange.Rh,
                        IdCD = pungaSange.IdCd
                    });

                    _server.TrombociteAdd(new PSTrombocite()
                    {
                        Cantitate = cantitateTrombocite,
                        Target = pungaSange.Target,
                        DataExpirare = expirareTrombocite,
                        Grupa = pungaSange.Grupa,
                        Rh = pungaSange.Rh,
                        IdCD = pungaSange.IdCd
                    });

                    _server.GlobuleRosiiAdd(new PSGlobuleRosii()
                    {
                        Cantitate = cantitateGlobule,
                        Target = pungaSange.Target,
                        DataExpirare = expirareGlobule,
                        Grupa = pungaSange.Grupa,
                        Rh = pungaSange.Rh,
                        IdCD = pungaSange.IdCd
                    });
                }
                else
                {
                    _server.PlasmaAdd(new PSPlasma()
                    {
                        Cantitate = cantitatePlasma,
                        Target = null,
                        DataExpirare = expirarePlasma,
                        Grupa = pungaSange.Grupa,
                        Rh = pungaSange.Rh,
                        IdCD = pungaSange.IdCd
                    });

                    _server.TrombociteAdd(new PSTrombocite()
                    {
                        Cantitate = cantitateTrombocite,
                        Target = null,
                        DataExpirare = expirareTrombocite,
                        Grupa = pungaSange.Grupa,
                        Rh = pungaSange.Rh,
                        IdCD = pungaSange.IdCd
                    });

                    _server.GlobuleRosiiAdd(new PSGlobuleRosii()
                    {
                        Cantitate = cantitateGlobule,
                        Target = null,
                        DataExpirare = expirareGlobule,
                        Grupa = pungaSange.Grupa,
                        Rh = pungaSange.Rh,
                        IdCD = pungaSange.IdCd
                    });

                }

                _server.PungaSangeDelete(pungaSange);

            }
            catch (NetworkingException e)
            {
                throw new SeviceException(e.Message);
            }
        }
    }
}
