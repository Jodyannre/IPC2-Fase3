using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pasillo
/// </summary>
public class pasillo
{
    private int numero;
    private float largo;
    private float ancho;
    private List<estante> estante;
    private float espacioRestante;
    public pasillo(int numero,float largo, float ancho)
    {
        this.espacioRestante = this.largo;
        this.estante = new List<estante>();
        this.numero = numero;
        this.largo = largo;
        this.ancho = ancho;
    }
    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }
    public float Largo
    {
        get { return largo; }
        set { largo = value; }
    }
    public float Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }

    public List<estante> Estante { get => estante; set => estante = value; }
    public float EspacioRestante { get => espacioRestante; set => espacioRestante = value; }
}