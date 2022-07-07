using System;
using System.Collections.Generic;
namespace TP06;


public class Jugador
{
    private int _idJugador;
    private int _idEquipo;
    private string _nombre;
    private DateTime _fechaNacimiento;
    private string _foto;
    private string _equipoActual;
   
   
    public Jugador(int IdJugador, int idEquipo, string nombre,DateTime fechaNacimiento, string foto, string equipoActual)
        {
           _idJugador= idJugador;
           _idEquipo= idEquipo;
           _nombre= nombre;
           _fechaNacimiento= fechaNacimiento;
           _foto= foto;
           _equipoActual= equipoActual;
        

        }
    
    public Jugador()
        {
        }
    public int IdJugador
    {
        get
        {
            return _idJugador;
        }
        set{
            _idJugador = value;
        }

    }
    public int IdEquipo
    {
        get
        {
            return _idEquipo;
        }
        set{
            _idEquipo = value;
        }

    }

    public string Nombre
    {
        get
        {
            return _nombre;
        }
        set{
            _nombre = value;
        }
    }

    public DateTime FechaNacimiento
    {
        get
        {
            return _fechaNacimiento;
        }
        set{
            _fechaNacimiento = value;
        }
    }
     public string Foto
    {
        get
        {
            return _foto;
        }
        set{
            _foto = value;
        }
    }
    public string EquipoActual
    {
        get
        {
            return _equipoActual;
        }
        set{
            _equipoActual = value;
        }
    }
     


    

}