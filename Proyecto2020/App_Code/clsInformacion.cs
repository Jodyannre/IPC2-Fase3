using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Clase que guarda la informacion de la conexion
/// </summary>
public class clsInformacion: clsConexion
{
    string tabla = "nombre"; //nombre de la tabla
    protected string idUsuario, nombre;
    public clsInformacion()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}