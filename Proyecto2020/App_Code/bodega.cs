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
    private List<pasillo> pasillo;
    public bodega(string nombre, int tamaño, string ubicacion)
    {
        crearCodigo();
        this.pasillo = new List<pasillo>();
        this.nombre = nombre;
        this.tamaño = tamaño;
        this.ubicacion = ubicacion;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public int Tamaño
    {
        get { return tamaño; }
        set { tamaño = value; }
    }
    public string Ubicacion
    {
        get { return ubicacion; }
        set { ubicacion = value; }
    }

    public List<pasillo> Pasillo { get => pasillo; set => pasillo = value; }

    private void crearCodigo()
    {
        this.codigo = contador;
        contador++;
    }
}