﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSApp.Domain;
using ISSApp.Exceptions;

namespace Server.Repository
{
    class SQLAdresaRepo : ISqlRepo<Adresa>
    {
        public void Add(Adresa entity)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO Adrese(Strada, Numar, Oras, Judet) VALUES (@Strada, @Numar, @Oras, @Judet)";

                    var paramStrada = command.CreateParameter();
                    paramStrada.ParameterName = "@Strada";
                    paramStrada.Value = entity.Strada;
                    command.Parameters.Add(paramStrada);

                    var paramNumar = command.CreateParameter();
                    paramNumar.ParameterName = "@Numar";
                    paramNumar.Value = entity.Numar;
                    command.Parameters.Add(paramNumar);

                    var paramOras = command.CreateParameter();
                    paramOras.ParameterName = "@Oras";
                    paramOras.Value = entity.Oras;
                    command.Parameters.Add(paramOras);

                    var paramJudet = command.CreateParameter();
                    paramJudet.ParameterName = "@Judet";
                    paramJudet.Value = entity.Judet;
                    command.Parameters.Add(paramJudet);

                    command.ExecuteNonQuery();

                }
                catch (SqlException)
                {
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
            connection.Close();
        }

        public Adresa Delete(Adresa entity)
        {
            IDbConnection connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM Adrese WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = entity.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                   
                    if (result != 0)
                    {
                        return entity;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public Adresa Update(Adresa entity)
        {
            IDbConnection connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE Adrese SET Strada=@Strada, Numar=@Numar, Oras=@Oras, Judet=@Judet WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = entity.Id;
                    command.Parameters.Add(paramId);

                    var paramStrada = command.CreateParameter();
                    paramStrada.ParameterName = "@Strada";
                    paramStrada.Value = entity.Strada;
                    command.Parameters.Add(paramStrada);

                    var paramNumar = command.CreateParameter();
                    paramNumar.ParameterName = "@Numar";
                    paramNumar.Value = entity.Numar;
                    command.Parameters.Add(paramNumar);

                    var paramOras = command.CreateParameter();
                    paramOras.ParameterName = "@Oras";
                    paramOras.Value = entity.Oras;
                    command.Parameters.Add(paramOras);

                    var paramJudet = command.CreateParameter();
                    paramJudet.ParameterName = "@Judet";
                    paramJudet.Value = entity.Judet;
                    command.Parameters.Add(paramJudet);

                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return entity;
                    }

                    return null;
                }
                catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public Adresa FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM Adrese WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int idAdresa = result.GetInt32(0);
                            String strada = result.GetString(1);
                            int numar = result.GetInt32(2);
                            String oras = result.GetString(3);
                            String judet = result.GetString(4);

                            Adresa adresa = new Adresa(idAdresa, strada, numar, oras, judet);
                            return adresa;
                        }

                        return null;
                    }

                }
                catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }

        public List<Adresa> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<Adresa> toReturn = new List<Adresa>();
                    command.CommandText = "SELECT * FROM Adrese";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            toReturn.Add(new Adresa(result.GetInt32(0), result.GetString(1), result.GetInt32(2), result.GetString(3), result.GetString(4)));
                        }
                    }

                    return toReturn;
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Returnarea adreselor din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }
    }
}
