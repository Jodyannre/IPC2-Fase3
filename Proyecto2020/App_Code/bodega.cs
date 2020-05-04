using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for crearBodega
/// </summary>
public class bodega
{
    private int codigo;
    private static int contador = 0;
    private string nombre;
    private int tamaño;
    private string ubicacion;
    private string descripcion;
    private List<pasillo> pasillos;
    public bodega(string nombre, string descripcion, int tamaño, string ubicacion)
    {
        crearCodigo();
        this.pasillos = new List<pasillo>();
        this.nombre = nombre;
        this.tamaño = tamaño;
        this.descripcion = descripcion;
        this.ubicacion = ubicacion;
    }


    public List<pasillo> Pasillo { get => pasillos; set => pasillos = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Tamaño { get => tamaño; set => tamaño = value; }
    public string Ubicacion { get => ubicacion; set => ubicacion = value; }

    private void crearCodigo()
    {
        this.codigo = contador;
        contador++;
    }
    public void agregarPasillo(pasillo pasillo)
    {
        this.pasillos.Add(pasillo);
    }
}