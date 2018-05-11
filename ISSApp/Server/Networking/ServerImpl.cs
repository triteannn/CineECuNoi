using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSApp.Domain;
using ISSApp.Networking;
using Server.Repository; 

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
            throw new NotImplementedException();
        }

        public Account AccountDelete(Account account)
        {
            throw new NotImplementedException();
        }

        public Account AccountFindAccountByCredentials(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<Account> AccountFindAll()
        {
            throw new NotImplementedException();
        }

        public Account AccountFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Account AccountUpdate(Account account)
        {
            throw new NotImplementedException();
        }

        public void AngajatAdd(AngajatCentru angajatCentru)
        {
            throw new NotImplementedException();
        }

        public AngajatCentru AngajatDelete(AngajatCentru angajatCentru)
        {
            throw new NotImplementedException();
        }

        public List<AngajatCentru> AngajatFindAll()
        {
            throw new NotImplementedException();
        }

        public AngajatCentru AngajatFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public AngajatCentru AngajatUpdate(AngajatCentru angajatCentru)
        {
            throw new NotImplementedException();
        }

        public void CentruDonareAdd(CentruDonare centru)
        {
            throw new NotImplementedException();
        }

        public CentruDonare CentruDonareDelete(CentruDonare centru)
        {
            throw new NotImplementedException();
        }

        public List<CentruDonare> CentruDonareFindAll()
        {
            throw new NotImplementedException();
        }

        public CentruDonare CentruDonareFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public CentruDonare CentruDonareUpdate(CentruDonare centru)
        {
            throw new NotImplementedException();
        }

        public void DonatorAdd(Donator donator)
        {
            throw new NotImplementedException();
        }

        public Donator DonatorDelete(Donator donator)
        {
            throw new NotImplementedException();
        }

        public List<Donator> DonatorFindAll()
        {
            throw new NotImplementedException();
        }

        public Donator DonatorFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Donator DonatorUpdate(Donator donator)
        {
            throw new NotImplementedException();
        }

        public void FormularCerereAdd(FormularCerere formular)
        {
            throw new NotImplementedException();
        }

        public FormularCerere FormularCerereDelete(FormularCerere formular)
        {
            throw new NotImplementedException();
        }

        public List<FormularCerere> FormularCerereFindAll()
        {
            throw new NotImplementedException();
        }

        public FormularCerere FormularCerereFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public FormularCerere FormularCerereUpdate(FormularCerere formular)
        {
            throw new NotImplementedException();
        }

        public void FormularDonareAdd(FormularDonare formular)
        {
            throw new NotImplementedException();
        }

        public FormularDonare FormularDonareDelete(FormularDonare formular)
        {
            throw new NotImplementedException();
        }

        public List<FormularDonare> FormularDonareFindAll()
        {
            throw new NotImplementedException();
        }

        public FormularDonare FormularDonareFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public FormularDonare FormularDonareUpdate(FormularDonare formular)
        {
            throw new NotImplementedException();
        }

        public void GlobuleRosiiAdd(PSGlobuleRosii psGlobuleRosii)
        {
            throw new NotImplementedException();
        }

        public PSGlobuleRosii GlobuleRosiiDelete(PSGlobuleRosii psGlobuleRosii)
        {
            throw new NotImplementedException();
        }

        public List<PSGlobuleRosii> GlobuleRosiiFindAll()
        {
            throw new NotImplementedException();
        }

        public List<PSGlobuleRosii> GlobuleRosiiFindByTarget(string target)
        {
            throw new NotImplementedException();
        }

        public PSGlobuleRosii GlobuleRosiiFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public PSGlobuleRosii GlobuleRosiiUpdate(PSGlobuleRosii psGlobuleRosii)
        {
            throw new NotImplementedException();
        }

        public void MedicAdd(Medic medic)
        {
            throw new NotImplementedException();
        }

        public Medic MedicDelete(Medic medic)
        {
            throw new NotImplementedException();
        }

        public List<Medic> MedicFindAll()
        {
            throw new NotImplementedException();
        }

        public Medic MedicFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Medic MedicUpdate(Medic medic)
        {
            throw new NotImplementedException();
        }

        public void PlasmaAdd(PSPlasma psPlasma)
        {
            throw new NotImplementedException();
        }

        public PSPlasma PlasmaDelete(PSPlasma psPlasma)
        {
            throw new NotImplementedException();
        }

        public List<PSPlasma> PlasmaFindAll()
        {
            throw new NotImplementedException();
        }

        public List<PSPlasma> PlasmaFindByTarget(string target)
        {
            throw new NotImplementedException();
        }

        public PSPlasma PlasmaFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public PSPlasma PlasmaUpdate(PSPlasma psPlasma)
        {
            throw new NotImplementedException();
        }

        public void PungaSangeAdd(PungaSange pungaSange)
        {
            throw new NotImplementedException();
        }

        public PungaSange PungaSangeDelete(PungaSange pungaSange)
        {
            throw new NotImplementedException();
        }

        public List<PungaSange> PungaSangeFindAll()
        {
            throw new NotImplementedException();
        }

        public List<PungaSange> PungaSangeFindByTarget(string target)
        {
            throw new NotImplementedException();
        }

        public PungaSange PungaSangeFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public PungaSange PungaSangeUpdate(PungaSange pungaSange)
        {
            throw new NotImplementedException();
        }

        public void SpitalAdd(Spital spital)
        {
            throw new NotImplementedException();
        }

        public Spital SpitalDelete(Spital spital)
        {
            throw new NotImplementedException();
        }

        public List<Spital> SpitalFindAll()
        {
            throw new NotImplementedException();
        }

        public Spital SpitalFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Spital SpitalUpdate(Spital spital)
        {
            throw new NotImplementedException();
        }

        public void TrombociteAdd(PSTrombocite psTrombocite)
        {
            throw new NotImplementedException();
        }

        public PSTrombocite TrombociteDelete(PSTrombocite psTrombocite)
        {
            throw new NotImplementedException();
        }

        public List<PSTrombocite> TrombociteFindAll()
        {
            throw new NotImplementedException();
        }

        public List<PSTrombocite> TrombociteFindByTarget(string target)
        {
            throw new NotImplementedException();
        }

        public PSTrombocite TrombociteFindEntity(int id)
        {
            throw new NotImplementedException();
        }

        public PSTrombocite TrombociteUpdate(PSTrombocite psTrombocite)
        {
            throw new NotImplementedException();
        }
    }
}
