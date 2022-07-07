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
namespace TP06;


public class BD {

    private static string _connectionString = @"Server=A-CRO-01\SQLEXPRESS;
    DataBase=Qatar2022;
    Trusted_Connection=True";

    /*public static List<Pelicula> ObtenerPeliculas(){
        List<Pelicula> lista = new List<Pelicula>();
        string sql = "SELECT * FROM Peliculas";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            lista = db.Query<Pelicula>(sql).ToList();
        }
        return lista;
    }

    public static void InsertarPelicula(string nombre, int duracion, string director){
        string sql = "INSERT INTO Peliculas VALUES (@pNombre, @pDuracion, @pDirector)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pNombre = nombre, pDuracion = duracion, pDirector = director });
        }
    }

    public static void EliminarPelicula(int id){
        string sql = "DELETE FROM Peliculas WHERE IdPelicula = @pId";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pId = id });
        }
    }*/


}