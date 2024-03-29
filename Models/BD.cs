/*Clase estática BD  con los siguientes métodos públicos (Crear todos los métodos privados que se requieran)
AgregarJugador(Jugador Jug) Agrega el jugador a la base de datos.
EliminarJugador(int IdJugador) Elimina el jugador de la base de datos.
VerInfoEquipo(int IdEquipo): devuelve un objeto Equipo
VerInfoJugador(int IdJugador): Devuelve un objeto Jugador
ListarEquipos(): Devuelve un List de Equipos
ListarJugadores(int IdEquipo): Devuelve un List de Jugadores*/
using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace TP06.Models;
    public class BD {

 private static string _connectionString = 
        @"Server=A-PHZ2-CIDI-010;
        DataBase=Qatar2022;Trusted_Connection=True;";

    /*AgregarJugador(Jugador Jug) Agrega el jugador a la base de datos.*/

    public static void AgregarJugador(Jugador Jug){
        string sql = "INSERT INTO Jugadores  (IdEquipo, Nombre, FechaNacimiento, Foto, EquipoActual) VALUES (@pIdEquipo, @pNombre, @pFechaNacimiento, @pFoto, @pEquipoActual)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new { pIdEquipo=Jug.IdEquipo, pNombre= Jug.Nombre, pFechaNacimiento=Jug.FechaNacimiento, pFoto=Jug.Foto, pEquipoActual=Jug.EquipoActual });
        }
    }
    public static void AgregarEquipo(Equipo Equ){
        string sql = "INSERT INTO Equipos  (Nombre, Escudo, Camiseta, Continente, CopasGanadas) VALUES (@pNombre, @pEscudo, @pCamiseta, @pContinente, @pCopasGanadas)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new { pNombre= Equ.Nombre, pEscudo=Equ.Escudo, pCamiseta=Equ.Camiseta, pContinente=Equ.Continente, pCopasGanadas=Equ.CopasGanadas });
        }
    }
    /*EliminarJugador(int IdJugador) Elimina el jugador de la base de datos.*/
     public static void EliminarJugador(int id){
        
        string sql = "DELETE FROM Jugadores WHERE IdJugador = @pId";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pId = id });
        }
        
    }
    /*VerInfoEquipo(int IdEquipo): devuelve un objeto Equipo*/
    public static Equipo VerInfoEquipo(int IdEquipo){
       Equipo MiEquipo=null; 
        string sql = "SELECT * FROM Equipos WHERE IdEquipo = @pIdEquipo";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            MiEquipo = db.QueryFirstOrDefault<Equipo>(sql, new {pIdEquipo = IdEquipo});
        }
        return MiEquipo;
    }
    /*VerInfoJugador(int IdJugador): Devuelve un objeto Jugador*/
    public static Jugador VerInfoJugador(int IdJugador){
        Jugador MiJugador=null;
        string sql = "SELECT * FROM Jugadores WHERE IdJugador = @pIdJugador";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            MiJugador = db.QueryFirstOrDefault<Jugador>(sql, new {pIdJugador=IdJugador});
        }
        return MiJugador;
    }
/*ListarEquipos(): Devuelve un List de Equipos*/
 public static List<Equipo> ListarEquipos(){
        List<Equipo> lista = new List<Equipo>();
        string sql = "SELECT * FROM Equipos";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            lista = db.Query<Equipo>(sql).ToList();
        }
        return lista;
    }
    /*ListarJugadores(int IdEquipo): Devuelve un List de Jugadores*/
    public static List<Jugador> ListarJugadores(int IdEquipo){
        List<Jugador> lista = new List<Jugador>();
        string sql = "SELECT * FROM Jugadores";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            lista = db.Query<Jugador>(sql).ToList();
        }
        return lista;
    }


}



