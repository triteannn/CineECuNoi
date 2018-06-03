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
                throw new ServiceException(e.Message);
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
                throw new ServiceException(e.Message);
            }
        }

        public void addPlasma(float cantitate, DateTime dataExpirare, string grupa, string rh, int idCD)
        {
            try
            {
                PSPlasma plasma = new PSPlasma()
                {
                    Cantitate = cantitate,
                    Target = null,
                    DataExpirare = dataExpirare,
                    Grupa = grupa,
                    Rh = rh,
                    IdCD = idCD
                };
                _server.PlasmaAdd(plasma);

            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }           
        }

        public void addTrombocite(float cantitate, DateTime dataExpirare, string grupa, string rh, int idCD)
        {
            try
            {
                PSTrombocite trombocite = new PSTrombocite()
                {
                    Cantitate = cantitate,
                    Target = null,
                    DataExpirare = dataExpirare,
                    Grupa = grupa,
                    Rh = rh,
                    IdCD = idCD
                };
                _server.TrombociteAdd(trombocite);

            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void addGlobule(float cantitate, DateTime dataExpirare, string grupa, string rh, int idCD)
        {
            try
            {
                PSGlobuleRosii globule = new PSGlobuleRosii()
                {
                    Cantitate = cantitate,
                    Target = null,
                    DataExpirare = dataExpirare,
                    Grupa = grupa,
                    Rh = rh,
                    IdCD = idCD
                };
                _server.GlobuleRosiiAdd(globule);

            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void addAnaliza(PungaSange pungaSange, string grupa, string rh, double eritrocite, double hemoglobina, double hematocrit,
            double vEM, double hEM, double cHEM, double latimeDistribEritrocit, double trombocite,
            double volumMediuTrombocitar, double trombocrit, double latimeDistribTrombocit, double leucocite,
            double granulocite, double limfocite, double mID, double numarGranulocite, double numarLimfocite,
            double numarMID, double glicemie, double aLT_TGP, double colesterol, string listaBoliDetectate)
        {
            try
            {
                Analiza analiza = new Analiza()
                {
                    DataRecoltarii = pungaSange.DataRecoltare,
                    Eritrocite = eritrocite,
                    Hemoglobina = hemoglobina,
                    Hematocrit = hematocrit,
                    VEM = vEM,
                    HEM = hEM,
                    CHEM = cHEM,
                    LatimeDistribEritrocit = latimeDistribEritrocit,
                    Trombocite = trombocite,
                    VolumMediuTrombocitar = volumMediuTrombocitar,
                    Trombocrit = trombocrit,
                    LatimeDistribTrombocit = latimeDistribTrombocit,
                    Leucocite = leucocite,
                    Granulocite = granulocite,
                    Limfocite = limfocite,
                    MID = mID,
                    NumarGranulocite = numarGranulocite,
                    NumarLimfocite = numarLimfocite,
                    NumarMID = numarMID,
                    Glicemie = glicemie,
                    ALT_TGP = aLT_TGP,
                    Colesterol = colesterol,
                    ListaBoliDetectate = listaBoliDetectate,
                };
                _server.AnalizaAdd(pungaSange, grupa, rh, analiza);

            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }           
        }

        public AngajatCentru findByIdAccount(int id)
        {
            try
            {
                return _server.AngajatFindByIdAccount(id);

            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
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
                throw new ServiceException(e.Message);
            }
        }

        public List<PungaSangeCuCNP> GetPungaSangeCuCNP(string cnp)
        {
            try
            {
                return _server.GetPungaSangeCuCNP(cnp);
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public double GetDistantaIntreAdrese(Adresa sursa, Adresa destinatie)
        {
            try
            {
                return Adresa.DistantaIntreAdrese(sursa, destinatie);
            }
            catch (NetworkingException e)
            {
                throw new ServiceException(e.Message);
            }
        }

    }
}
