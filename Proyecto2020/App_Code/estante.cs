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
    private static int contador=0;

    public estante(float largo, float ancho, float altura)
    {
        crearId();
        this.espacioRestante = this.altura;
        this.nivel = new List<nivel>();
        this.largo = largo;
        this.ancho = ancho;
        this.altura = altura;

    }


    public List<nivel> Nivel { get => nivel; set => nivel = value; }
    public float EspacioRestante { get => espacioRestante; set => espacioRestante = value; }
    public int Id { get => id;}
    public float Largo { get => largo; set => largo = value; }
    public float Ancho { get => ancho; set => ancho = value; }
    public float Altura { get => altura; set => altura = value; }

    private void crearId()
    {
        this.id = contador;
        contador += 1;
    }
}