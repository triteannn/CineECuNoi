using ISSApp.Domain;
using ISSApp.Exceptions;
using ISSApp.Networking;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Data;

namespace Server.Networking
{
    public class ServerImpl : MarshalByRefObject, IServer
    {
        private readonly SqlAccountRepo accountRepo;
        private readonly SQLAdresaRepo adresaRepo;
        private readonly SqlAngajatRepo angajatRepo;
        private readonly SqlCentruDonareRepo centruDonareRepo;
        private readonly SQLDateContact dateContactRepo;
        private readonly SqlDonatorRepo donatorRepo;
        private readonly SqlFormularCerereRepo formularCerereRepo;
        private readonly SqlFormularDonareRepo formularDonareRepo;
        private readonly SqlGlobuleRosiiRepo globuleRosiiRepo;
        private readonly SqlMedicRepo medicRepo;
        private readonly SqlPlasmaRepo plasmaRepo;
        private readonly SqlPungaSangeRepo pungaSangeRepo;
        private readonly SqlSpitalRepo spitalRepo;
        private readonly SqlTrombociteRepo trombociteRepo;
        private readonly SQLAnalizaRepo analizaRepo;

        public ServerImpl()
        {
            accountRepo = new SqlAccountRepo();
            adresaRepo = new SQLAdresaRepo();
            angajatRepo = new SqlAngajatRepo();
            centruDonareRepo = new SqlCentruDonareRepo();
            dateContactRepo = new SQLDateContact();
            donatorRepo = new SqlDonatorRepo();
            formularCerereRepo = new SqlFormularCerereRepo();
            formularDonareRepo = new SqlFormularDonareRepo();
            globuleRosiiRepo = new SqlGlobuleRosiiRepo();
            medicRepo = new SqlMedicRepo();
            plasmaRepo = new SqlPlasmaRepo();
            pungaSangeRepo = new SqlPungaSangeRepo();
            spitalRepo = new SqlSpitalRepo();
            trombociteRepo = new SqlTrombociteRepo();
            analizaRepo = new SQLAnalizaRepo();
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

        public void AdresaAdd(Adresa entity)
        {
            try
            {
                adresaRepo.Add(entity);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Adresa AdresaDelete(Adresa entity)
        {
            try
            {
                return adresaRepo.Delete(entity);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Adresa AdresaUpdate(Adresa entity)
        {
            try
            {
                return adresaRepo.Update(entity);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Adresa AdresaFindEntity(int id)
        {
            try
            {
                return adresaRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<Adresa> AdresaFindAll()
        {
            try
            {
                return adresaRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Adresa AdresaGetAdresaByDateContactId(int idDC)
        {
            try
            {
                return adresaRepo.GetAdresaByDateContactId(idDC);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public int AdresaAdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                return adresaRepo.AdminUpdateDataBase(dataSet);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public DataSet AdresaAdminGetDataSet()
        {
            try
            {
                return adresaRepo.AdminGetDataSet();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public DataSet AccountAdminGetDataSet()
        {
            try
            {
                return accountRepo.AdminGetDataSet();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public int AccountAdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                return accountRepo.AdminUpdateDataBase(dataSet);
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

        public AngajatCentru AngajatFindByIdAccount(int id)
        {
            try
            {
                return angajatRepo.FindByIdAccount(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }
        public AngajatCentru AngajatFindByUsername(string username)
        {
            try
            {
                return angajatRepo.FindByUsername(username);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }
        public DataSet AngajatAdminGetDataSet()
        {
            try
            {
                return angajatRepo.AdminGetDataSet();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public int AngajatAdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                return angajatRepo.AdminUpdateDataBase(dataSet);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<PungaSangeCuCNP> getPungaSangeCuCNP()
        {
            throw new NotImplementedException();
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

        public CentruDonare CentruDonareFindByDenumire(string denumire)
        {
            try
            {
                return centruDonareRepo.FindCentruDonareByDenumire(denumire);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public DataSet CentruDonareAdminGetDataSet()
        {
            try
            {
                return centruDonareRepo.AdminGetDataSet();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public int CentruDonareAdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                return centruDonareRepo.AdminUpdateDataBase(dataSet);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public void DateContactAdd(DateContact entity)
        {
            try
            {
                dateContactRepo.Add(entity);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }
        public DateContact DateContactDelete(DateContact entity)
        {
            try
            {
                return dateContactRepo.Delete(entity);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public DateContact DateContactUpdate(DateContact entity)
        {
            try
            {
                return dateContactRepo.Update(entity);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public DateContact DateContactFindEntity(int id)
        {
            try
            {
                return dateContactRepo.FindEntity(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<DateContact> DateContactFindAll()
        {
            try
            {
                return dateContactRepo.FindAll();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public DateContact DateContactGetDateByIdDonator(int idDonator)
        {
            try
            {
                return dateContactRepo.GetDateByIdDonator(idDonator);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public DateContact DateContactFindLastEntity()
        {
            try
            {
                return dateContactRepo.FindLastEntity();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public int DateContactAdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                return dateContactRepo.AdminUpdateDataBase(dataSet);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public DataSet DateContactAdminGetDataSet()
        {
            try
            {
                return dateContactRepo.AdminGetDataSet();
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

        public void DonatorAddFull(Donator donator)
        {
            try
            {
                donatorRepo.AddFull(donator);
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

        public Donator DonatorFindEntityByName(string fullName)
        {
            try
            {
                return donatorRepo.FindEntityByName(fullName);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Donator DonatorFindByUsername(string username)
        {
            try
            {
                return donatorRepo.FindByUsername(username);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Donator DonatorFindByIdAccount(int id)
        {
            try
            {
                return donatorRepo.FindByIdAccount(id);
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

        public int DonatorAdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                return donatorRepo.AdminUpdateDataBase(dataSet);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public DataSet DonatorAdminGetDataSet()
        {
            try
            {
                return donatorRepo.AdminGetDataSet();
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

        /*
         * verifica existenta unui target cu cnpul mentionat
         */
        public bool ExistaCNP(string cnp)
        {
            return formularCerereRepo.ExistaCNP(cnp);
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

        public FormularDonare FormularDonareGetLastFormular(int idDonator)
        {
            try
            {
                return formularDonareRepo.GetLastFormular(idDonator);
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

        public List<PSGlobuleRosii> GlobuleRosiiFindAllByCentru(int idCentru)
        {
            try
            {
                return globuleRosiiRepo.FindAllByCentru(idCentru);
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

        public Medic MedicFindByIdAccount(int id)
        {
            try
            {
                return medicRepo.FindByIdAccount(id);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Medic MedicFindByUsername(string username)
        {
            try
            {
                return medicRepo.FindByUsername(username);
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

        public DataSet MedicAdminGetDataSet()
        {
            try
            {
                return medicRepo.AdminGetDataSet();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public int MedicAdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                return medicRepo.AdminUpdateDataBase(dataSet);
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

        public List<PSPlasma> PlasmaFindAllByCentru(int idCentru)
        {
            try
            {
                return plasmaRepo.FindAllByCentru(idCentru);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }


        public void PungaSangeAdd(PungaSange pungaSange)
        {
            try
            {
                /*if (!formularCerereRepo.ExistaCNP(pungaSange.Target))
                {
                    pungaSange.Target = null;

                }

                pungaSangeRepo.AddInitial(pungaSange);*/
                pungaSangeRepo.Add(pungaSange);
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

        public DataSet SpitalAdminGetDataSet()
        {
            try
            {
                return spitalRepo.AdminGetDataSet();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public int SpitalAdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                return spitalRepo.AdminUpdateDataBase(dataSet);
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

        public List<PSTrombocite> TrombociteFindAllByCentru(int idCentru)
        {
            try
            {
                return trombociteRepo.FindAllByCentru(idCentru);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }


        public void AnalizaAdd(Analiza analiza) // cum pun in service? In care service? 
        {
            try
            {
                analizaRepo.Add(analiza);

            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Analiza AnalizaFindLastByDonator(int idDonator)
        {
            try
            {
                return analizaRepo.FindLastByDonator(idDonator);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<Analiza> AnalizaFindByDonator(int idDonator)
        {
            try
            {
                return analizaRepo.FindByDonator(idDonator);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public List<PungaSangeCuCNP> GetPungaSangeCuCNP(string cnp)
        {
            try
            {
                return pungaSangeRepo.GetPungaSangeCuCNP(cnp);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        public Analiza AnalizaFindLastEntity()
        {
            try
            {
                return analizaRepo.FindLastEntity();
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }

        /*
         * Se returneaza o lista cu pungile de sange, care au atasate CNP-ul donatorului.
         */
        /*public List<PungaSangeCuCNP> getPungaSangeCuCNP()
        {
            try
            {
                return analizaRepo.FindLastByDonator(idDonator);
            } catch (RepositoryException e)
            {
                throw new NetworkingException(e.Message);
            }
        }*/
    }
}
