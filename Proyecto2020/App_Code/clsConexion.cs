using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Clase de conexion
/// </summary>
public class clsConexion
{
    protected SqlDataReader lector;
    protected SqlDataAdapter adaptador;
    protected DataSet dato;
    protected SqlConnection coneccion = new SqlConnection();
    public clsConexion()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void conectar(string tabla) {
        string laConeccion = ConfigurationManager.ConnectionStrings["HelloWorldConnectionString"].ConnectionString;
        coneccion.ConnectionString = laConeccion;
        coneccion.Open();
        adaptador = new SqlDataAdapter("select * from"+tabla, coneccion);
        SqlCommandBuilder comandos = new SqlCommandBuilder(adaptador);
        Dato = new DataSet();
        adaptador.Fill(Dato, tabla);
        coneccion.Close();
    }

    public DataSet Dato {
        set { dato = value; }
        get { return dato; }
    }

    public SqlDataReader DataReader {
        set{ lector = value; }
        get { return lector; }
    }


}