using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for proveedor
/// </summary>
public class proveedor
{
    private string nombre;
    private string nit;
    private string direccion;
    private int celular;
    private string correo;
    private string contacto;
    public proveedor(string nombre, string nit, string direccion,int celular, string correo,string contacto)
    {
        this.nombre = nombre;
        this.nit = nit;
        this.direccion = direccion;
        this.celular = celular;
        this.correo = correo;
        this.contacto = contacto;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Nit { get => nit; set => nit = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Celular { get => celular; set => celular = value; }
    public string Correo { get => correo; set => correo = value; }
    public string Contacto { get => contacto; set => contacto = value; }
}