using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for estante
/// </summary>
public class estante
{
    private int id;
    private float largo;
    private float ancho;
    private float altura;
    private List<nivel> nivel;
    private float espacioRestante;


    public estante(float largo, float ancho, float altura)
    {
        this.espacioRestante = this.altura;
        this.nivel = new List<nivel>();
        this.largo = largo;
        this.ancho = ancho;
        this.altura = altura;

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
    public float Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public List<nivel> Nivel { get => nivel; set => nivel = value; }
    public float EspacioRestante { get => espacioRestante; set => espacioRestante = value; }
}