using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for reporte
/// </summary>
public class reporte
{
    private string nombre;
    private string tipo;
    private string informacion;
    public reporte(string nombre, string tipo, string informacion)
    {
        this.nombre = nombre;
        this.tipo = tipo;
        this.informacion = informacion;
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }
    public string Informacion
    {
        get { return informacion; }
        set { informacion = value; }
    }
}