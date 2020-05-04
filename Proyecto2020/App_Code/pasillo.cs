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
    private List<estante> estantes;
    private float espacioRestante;
    public pasillo(int numero,float largo, float ancho)
    {
        this.espacioRestante = this.largo;
        this.estantes = new List<estante>();
        this.numero = numero;
        this.largo = largo;
        this.ancho = ancho;
    }


    public List<estante> Estante { get => estantes; set => estantes = value; }
    public float EspacioRestante { get => espacioRestante; set => espacioRestante = value; }
    public int Numero { get => numero; set => numero = value; }
    public float Largo { get => largo; set => largo = value; }
    public float Ancho { get => ancho; set => ancho = value; }

    public void agregarEstante(estante estante)
    {
        this.estantes.Add(estante);
    }
}
    