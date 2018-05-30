using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;

namespace ISSApp.Networking
{
    public interface IServer
    {
        //Account
        void AccountAdd(Account account);
        Account AccountDelete(Account account);
        Account AccountUpdate(Account account);
        Account AccountFindEntity(int id);
        Account AccountFindAccountByCredentials(string username, string password);
        List<Account> AccountFindAll();
        int AccountGetLastId();
        DataSet AccountAdminGetDataSet();
        int AccountAdminUpdateDataBase(DataSet dataSet);
        //
        //Angajat
        void AngajatAdd(AngajatCentru angajatCentru);
        AngajatCentru AngajatDelete(AngajatCentru angajatCentru);
        AngajatCentru AngajatUpdate(AngajatCentru angajatCentru);
        AngajatCentru AngajatFindEntity(int id);
        List<AngajatCentru> AngajatFindAll();
        AngajatCentru AngajatFindByIdAccount(int id);
        AngajatCentru AngajatFindByUsername(string username);
        DataSet AngajatAdminGetDataSet();
        int AngajatAdminUpdateDataBase(DataSet dataSet);

        //Analiza
        void AnalizaAdd(PungaSange pungaSange, string grupa, string rh, Analiza analiza);
        Analiza AnalizaFindLastByDonator(int idDonator);

        //
        //CentruDonare
        void CentruDonareAdd(CentruDonare centru);
        CentruDonare CentruDonareDelete(CentruDonare centru);
        CentruDonare CentruDonareUpdate(CentruDonare centru);
        CentruDonare CentruDonareFindEntity(int id);
        List<CentruDonare> CentruDonareFindAll();
        DataSet CentruDonareAdminGetDataSet();
        int CentruDonareAdminUpdateDataBase(DataSet dataSet);

        CentruDonare CentruDonareFindByDenumire(string denumire);
        //Donator
        void DonatorAdd(Donator donator);
        void DonatorAddFull(Donator donator);
        Donator DonatorDelete(Donator donator);
        Donator DonatorUpdate(Donator donator);
        Donator DonatorFindEntity(int id);
        List<Donator> DonatorFindAll();
        int DonatorGetLastId();
        int DonatorAdminUpdateDataBase(DataSet dataSet);
        DataSet DonatorAdminGetDataSet();
        Donator DonatorFindByUsername(string username);
        Donator DonatorFindByIdAccount(int id);

        //FormularCerere
        void FormularCerereAdd(FormularCerere formular);
        FormularCerere FormularCerereDelete(FormularCerere formular);
        FormularCerere FormularCerereUpdate(FormularCerere formular);
        FormularCerere FormularCerereFindEntity(int id);
        List<FormularCerere> FormularCerereFindAll();
        bool ExistaCNP(string cnp);
        //FormularDonare
        void FormularDonareAdd(FormularDonare formular);
        FormularDonare FormularDonareDelete(FormularDonare formular);
        FormularDonare FormularDonareUpdate(FormularDonare formular);
        FormularDonare FormularDonareFindEntity(int id);
        List<FormularDonare> FormularDonareFindAll();
        //GlobuleRosii
        void GlobuleRosiiAdd(PSGlobuleRosii psGlobuleRosii);
        PSGlobuleRosii GlobuleRosiiDelete(PSGlobuleRosii psGlobuleRosii);
        PSGlobuleRosii GlobuleRosiiUpdate(PSGlobuleRosii psGlobuleRosii);
        PSGlobuleRosii GlobuleRosiiFindEntity(int id);
        List<PSGlobuleRosii> GlobuleRosiiFindAll();
        List<PSGlobuleRosii> GlobuleRosiiFindByTarget(string target);

        //Medic
        void MedicAdd(Medic medic);
        Medic MedicDelete(Medic medic);
        Medic MedicUpdate(Medic medic);
        Medic MedicFindEntity(int id);
        List<Medic> MedicFindAll();
        Medic MedicFindByIdAccount(int id);
        Medic MedicFindByUsername(string username);
        DataSet MedicAdminGetDataSet();
        int MedicAdminUpdateDataBase(DataSet dataSet);

        //Plasma
        void PlasmaAdd(PSPlasma psPlasma);
        PSPlasma PlasmaDelete(PSPlasma psPlasma);
        PSPlasma PlasmaUpdate(PSPlasma psPlasma);
        PSPlasma PlasmaFindEntity(int id);
        List<PSPlasma> PlasmaFindAll();
        List<PSPlasma> PlasmaFindByTarget(string target);
        //PungaSange
        void PungaSangeAdd(PungaSange pungaSange);
        PungaSange PungaSangeDelete(PungaSange pungaSange);
        PungaSange PungaSangeUpdate(PungaSange pungaSange);
        PungaSange PungaSangeFindEntity(int id);
        List<PungaSange> PungaSangeFindAll();
        List<PungaSange> PungaSangeFindByTarget(string target);

        List<PungaSangeCuCNP> GetPungaSangeCuCNP(string cnp); 
        //Spital
        void SpitalAdd(Spital spital);
        Spital SpitalDelete(Spital spital);
        Spital SpitalUpdate(Spital spital);
        Spital SpitalFindEntity(int id);
        List<Spital> SpitalFindAll();
        DataSet SpitalAdminGetDataSet();
        int SpitalAdminUpdateDataBase(DataSet dataSet);
        //Trombocite
        void TrombociteAdd(PSTrombocite psTrombocite);
        PSTrombocite TrombociteDelete(PSTrombocite psTrombocite);
        PSTrombocite TrombociteUpdate(PSTrombocite psTrombocite);
        PSTrombocite TrombociteFindEntity(int id);
        List<PSTrombocite> TrombociteFindAll();
        List<PSTrombocite> TrombociteFindByTarget(string target);
    }
}
