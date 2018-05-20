﻿using ISSApp.Domain;
using ISSApp.Exceptions;
using ISSApp.Networking;
using Server.Repository;
using System;
using System.Collections.Generic;

namespace Server.Networking
{
    public class ServerImpl : MarshalByRefObject, IServer
    {
        private SqlAccountRepo accountRepo;
        private SqlAngajatRepo angajatRepo;
        private SqlCentruDonareRepo centruDonareRepo;
        private SqlDonatorRepo donatorRepo;
        private SqlFormularCerereRepo formularCerereRepo;
        private SqlFormularDonareRepo formularDonareRepo;
        private SqlGlobuleRosiiRepo globuleRosiiRepo;
        private SqlMedicRepo medicRepo;
        private SqlPlasmaRepo plasmaRepo;
        private SqlPungaSangeRepo pungaSangeRepo;
        private SqlSpitalRepo spitalRepo;
        private SqlTrombociteRepo trombociteRepo;
        private SQLAnalizaRepo analizaRepo;

        public ServerImpl()
        {
            accountRepo = new SqlAccountRepo();
            angajatRepo = new SqlAngajatRepo();
            centruDonareRepo = new SqlCentruDonareRepo();
            donatorRepo = new SqlDonatorRepo();
            formularCerereRepo = new SqlFormularCerereRepo();
            formularDonareRepo = new SqlFormularDonareRepo();
            globuleRosiiRepo = new SqlGlobuleRosiiRepo();
            medicRepo = new SqlMedicRepo();
            plasmaRepo = new SqlPlasmaRepo();
            pungaSangeRepo = new SqlPungaSangeRepo();
            spitalRepo = new SqlSpitalRepo();
            trombociteRepo = new SqlTrombociteRepo();
        }

        public void AccountAdd(Account account)
        {
            try
            {
                accountRepo.Add(account);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Account AccountDelete(Account account)
        {
            try
            {
                return accountRepo.Delete(account);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Account AccountFindAccountByCredentials(string username, string password)
        {
            try
            {
                return accountRepo.FindAccountByCredentials(username, password);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<Account> AccountFindAll()
        {
            try
            {
                return accountRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Account AccountFindEntity(int id)
        {
            try
            {
                return accountRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Account AccountUpdate(Account account)
        {
            try
            {
                return accountRepo.Update(account);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public int AccountGetLastId()
        {
            try
            {
                return accountRepo.GetLastId();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void AngajatAdd(AngajatCentru angajatCentru)
        {
            try
            {
                angajatRepo.Add(angajatCentru);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public AngajatCentru AngajatDelete(AngajatCentru angajatCentru)
        {
            try
            {
                return angajatRepo.Delete(angajatCentru);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<AngajatCentru> AngajatFindAll()
        {
            try
            {
                return angajatRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public AngajatCentru AngajatFindEntity(int id)
        {
            try
            {
                return angajatRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public AngajatCentru AngajatUpdate(AngajatCentru angajatCentru)
        {
            try
            {
                return angajatRepo.Update(angajatCentru);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void CentruDonareAdd(CentruDonare centru)
        {
            try
            {
                centruDonareRepo.Add(centru);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public CentruDonare CentruDonareDelete(CentruDonare centru)
        {
            try
            {
                return centruDonareRepo.Delete(centru);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<CentruDonare> CentruDonareFindAll()
        {
            try
            {
                return centruDonareRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public CentruDonare CentruDonareFindEntity(int id)
        {
            try
            {
                return centruDonareRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public CentruDonare CentruDonareUpdate(CentruDonare centru)
        {
            try
            {
                return centruDonareRepo.Update(centru);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void DonatorAdd(Donator donator)
        {
            try
            {
                donatorRepo.Add(donator);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Donator DonatorDelete(Donator donator)
        {
            try
            {
                return donatorRepo.Delete(donator);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<Donator> DonatorFindAll()
        {
            try
            {
                return donatorRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Donator DonatorFindEntity(int id)
        {
            try
            {
                return donatorRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Donator DonatorUpdate(Donator donator)
        {
            try
            {
                return donatorRepo.Update(donator);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public int DonatorGetLastId()
        {
            try
            {
                return donatorRepo.GetLastId();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void FormularCerereAdd(FormularCerere formular)
        {
            try
            {
                formularCerereRepo.Add(formular);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public FormularCerere FormularCerereDelete(FormularCerere formular)
        {
            try
            {
                return formularCerereRepo.Delete(formular);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<FormularCerere> FormularCerereFindAll()
        {
            try
            {
                return formularCerereRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public FormularCerere FormularCerereFindEntity(int id)
        {
            try
            {
                return formularCerereRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public FormularCerere FormularCerereUpdate(FormularCerere formular)
        {
            try
            {
                return formularCerereRepo.Update(formular);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void FormularDonareAdd(FormularDonare formular)
        {
            try
            {
                formularDonareRepo.Add(formular);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public FormularDonare FormularDonareDelete(FormularDonare formular)
        {
            try
            {
                return formularDonareRepo.Delete(formular);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<FormularDonare> FormularDonareFindAll()
        {
            try
            {
                return formularDonareRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public FormularDonare FormularDonareFindEntity(int id)
        {
            try
            {
                return formularDonareRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public FormularDonare FormularDonareUpdate(FormularDonare formular)
        {
            try
            {
                return formularDonareRepo.Update(formular);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void GlobuleRosiiAdd(PSGlobuleRosii psGlobuleRosii)
        {
            try
            {
                globuleRosiiRepo.Add(psGlobuleRosii);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PSGlobuleRosii GlobuleRosiiDelete(PSGlobuleRosii psGlobuleRosii)
        {
            try
            {
                return globuleRosiiRepo.Delete(psGlobuleRosii);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<PSGlobuleRosii> GlobuleRosiiFindAll()
        {
            try
            {
                return globuleRosiiRepo.FindAll();
            } catch (Exception)
            {

                throw;
            }
        }

        public List<PSGlobuleRosii> GlobuleRosiiFindByTarget(string target)
        {
            try
            {
                return globuleRosiiRepo.FindByTarget(target);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PSGlobuleRosii GlobuleRosiiFindEntity(int id)
        {
            try
            {
                return globuleRosiiRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PSGlobuleRosii GlobuleRosiiUpdate(PSGlobuleRosii psGlobuleRosii)
        {
            try
            {
                return globuleRosiiRepo.Update(psGlobuleRosii);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void MedicAdd(Medic medic)
        {
            try
            {
                medicRepo.Add(medic);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Medic MedicDelete(Medic medic)
        {
            try
            {
                return medicRepo.Delete(medic);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<Medic> MedicFindAll()
        {
            try
            {
                return medicRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Medic MedicFindEntity(int id)
        {
            try
            {
                return medicRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Medic MedicUpdate(Medic medic)
        {
            try
            {
                return medicRepo.Update(medic);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void PlasmaAdd(PSPlasma psPlasma)
        {
            try
            {
                plasmaRepo.Add(psPlasma);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PSPlasma PlasmaDelete(PSPlasma psPlasma)
        {
            try
            {
                return plasmaRepo.Delete(psPlasma);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<PSPlasma> PlasmaFindAll()
        {
            try
            {
                return plasmaRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<PSPlasma> PlasmaFindByTarget(string target)
        {
            try
            {
                return plasmaRepo.FindByTarget(target);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PSPlasma PlasmaFindEntity(int id)
        {
            try
            {
                return plasmaRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PSPlasma PlasmaUpdate(PSPlasma psPlasma)
        {
            try
            {
                return plasmaRepo.Update(psPlasma);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }


        public void PungaSangeAdd(PungaSange pungaSange)
        {
            try
            {
                pungaSangeRepo.AddInitial(pungaSange);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }



        public PungaSange PungaSangeDelete(PungaSange pungaSange)
        {
            try
            {
                return pungaSangeRepo.Delete(pungaSange);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<PungaSange> PungaSangeFindAll()
        {
            try
            {
                return pungaSangeRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<PungaSange> PungaSangeFindByTarget(string target)
        {
            try
            {
                return pungaSangeRepo.FindByTarget(target);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PungaSange PungaSangeFindEntity(int id)
        {
            try
            {
                return pungaSangeRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PungaSange PungaSangeUpdate(PungaSange pungaSange)
        {
            try
            {
                return pungaSangeRepo.Update(pungaSange);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void SpitalAdd(Spital spital)
        {
            try
            {
                spitalRepo.Add(spital);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Spital SpitalDelete(Spital spital)
        {
            try
            {
                return spitalRepo.Delete(spital);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<Spital> SpitalFindAll()
        {
            try
            {
                return spitalRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Spital SpitalFindEntity(int id)
        {
            try
            {
                return spitalRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Spital SpitalUpdate(Spital spital)
        {
            try
            {
                return spitalRepo.Update(spital);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void TrombociteAdd(PSTrombocite psTrombocite)
        {
            try
            {
                trombociteRepo.Add(psTrombocite);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PSTrombocite TrombociteDelete(PSTrombocite psTrombocite)
        {
            try
            {
                return trombociteRepo.Delete(psTrombocite);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<PSTrombocite> TrombociteFindAll()
        {
            try
            {
                return trombociteRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<PSTrombocite> TrombociteFindByTarget(string target)
        {
            try
            {
                return trombociteRepo.FindByTarget(target);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PSTrombocite TrombociteFindEntity(int id)
        {
            try
            {
                return trombociteRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public PSTrombocite TrombociteUpdate(PSTrombocite psTrombocite)
        {
            try
            {
                return trombociteRepo.Update(psTrombocite);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        
        public void AddAnaliza(PungaSange pungaSange, string grupa, string rh, Analiza analiza)
        {
            try
            {
                pungaSange.Grupa = grupa;
                pungaSange.Rh = rh;
                pungaSangeRepo.Update(pungaSange); 



            }
            catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<Analiza> AnalizaFindByDonator(int idDonator)
        {
            try
            {
                return analizaRepo.FindByDonator(idDonator);
            }
            catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }
    }
}
