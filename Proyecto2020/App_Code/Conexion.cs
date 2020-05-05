using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Conexion
/// </summary>
public class Conexion
{

    private SqlConnection con;
    private SqlCommand cmd;
    private string cadena;

    public Conexion(string nombreFuncion, CommandType tipo)
    {
        cadena = "Data Source=(local); Initial Catalog=Bro; Integrated Security=true";
        con = new SqlConnection(cadena);
        cmd = new SqlCommand(nombreFuncion, con);
        cmd.CommandType = tipo;
        con.Open();
    }
    
    public SqlCommand getCmd()
    {
        return this.cmd;
    }
    public void cerrarConexion()
    {
        con.Close();
    }

}