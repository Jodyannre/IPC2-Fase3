using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    private string cadena = "Data Source=(local); Initial Catalog=Bro; Integrated Security=true";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void bIngresar_Click(object sender, EventArgs e)
    {
        String nombre = txtNombre.Text;
        String pass = txtPass.Text;
        //se hace una conexión a la base de datos
        con = new SqlConnection(cadena);
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.CommandText = @"INSERT INTO Login(id_login, nombre, contraseña)
                                VALUES(@param1, @param2, @param3)";
        cmd.Parameters.AddWithValue("@param1", 1);
        cmd.Parameters.AddWithValue("@param2", nombre);
        cmd.Parameters.AddWithValue("@param3", pass);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (SqlException sqle)
        {
            Console.Write(sqle.Message);
        }
    }
}