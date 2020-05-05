using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Presentacion_crearPasillo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) //cuando cargue la página solo muestre los datos una vez
        {
            Conexion c = new Conexion("listadoBodega", CommandType.StoredProcedure);
            using (var reader = c.getCmd().ExecuteReader())
            {
                while (reader.Read())
                {
                    //se llena el dropdownlist con el nombre de la bodega y el id de la bodega
                    DropDownList1.Items.Insert(0, new ListItem(reader["Nombre"].ToString(), reader["Codigo"].ToString()));
                }
            }
            c.cerrarConexion();
        }
    }
    /*
        Al presionar el botón de *agregar* almacena los datos de la página y lo almacena en la BD devolviendo un resultado,
        Sí el resutado = -1 es porque existió un error de lo contrario todo fue éxitoso. 
    */
    protected void Button1_Click(object sender, EventArgs e)
    {
        DropDownList1.DataBind();
        ListItem li = DropDownList1.SelectedItem; //obtiene la bodega que está seleccionada.
        Conexion c = new Conexion("crearPasillo", CommandType.StoredProcedure);
        c.getCmd().Parameters.AddWithValue("@No_pasillo", Int32.Parse(TextBox1.Text));
        c.getCmd().Parameters.AddWithValue("@Largo", float.Parse(TextBox2.Text));
        c.getCmd().Parameters.AddWithValue("@Ancho", float.Parse(TextBox3.Text));
        c.getCmd().Parameters.AddWithValue("@Bodega", Int32.Parse(li.Value)); //obtiene el valor de la lista seleccionada.
        c.getCmd().Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
        c.getCmd().ExecuteNonQuery(); //ejecuta el comando y la almacena en la bd.

        int resultado = Convert.ToInt32(c.getCmd().Parameters["@Resultado"].Value); //obtener el resultado del procedimiento.
        if(resultado == -1) //existió un error.
        {

        }else
        {
            //guardado éxitoso.
        }
    }
}