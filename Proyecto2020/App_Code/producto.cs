using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for producto
/// </summary>
public class producto
{
    private int codigoP;
    private int codigoB;
    private string nombre;
    private string descripcion;
    private string presentacion;
    private string clasificacion;
    private float costoPromedio;
    public producto(int codigoP,int codigoB, string nombre, string descripcion, string presentacion, string clasificacion, float costoPromedio)
    {
        this.codigoP = codigoP;
        this.codigoB = codigoB;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.presentacion = presentacion;
        this.clasificacion = clasificacion;
        this.costoPromedio = costoPromedio;
    }
    public producto()
    {

    }


    public int CodigoP { get => codigoP; set => codigoP = value; }
    public int CodigoB { get => codigoB; set => codigoB = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public string Presentacion { get => presentacion; set => presentacion = value; }
    public string Clasificacion { get => clasificacion; set => clasificacion = value; }
    public float CostoPromedio { get => costoPromedio; set => costoPromedio = value; }
}