using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for nivel
/// </summary>
public class nivel
{
    private int id,numero;
    private float altura, ancho;
    private int contador;
    private float espacioRestante;

    public nivel(int numero, float altura, float ancho)
    {
        generarId();
        this.numero = numero;
        this.altura = altura;
        this.ancho = ancho;
        this.espacioRestante = 10;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }
    public float Altura
    {
        get { return altura; }
        set { altura = value; }
    }
    public float Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }

    public float EspacioRestante { get => espacioRestante; set => espacioRestante = value; }

    private void generarId()
    {
        this.id = contador;
        contador++;
    }
    public void ingresarProductos(lote lote)
    {
        if (lote.Tipo == tipo.PEPS)
        {
            while (this.espacioRestante>0)
            {

            }
        }
        else if (lote.Tipo == tipo.UEPS)
        {

        }
    }
    public void ingresarProductos(List<producto> productos)
    {

    }
}