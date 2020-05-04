using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for lote
/// </summary>
public class lote
{
    private int tip;
    private List<producto> valor;
    private int tamaño;
    private float precio;
    private Stack<producto> ueps;
    private Queue<producto> peps;


    public lote(int tip,int tamaño)
    {
        this.ueps = new Stack<producto>();
        this.peps = new Queue<producto>();
        valor = new List<producto>();
        this.tip = tip;
        this.tamaño = tamaño;
        this.precio = 0;
    }

    public producto ingresarBodega()
    {
        if (this.tip == tipo.PEPS && this.tamaño >0){
            this.tamaño -= 1;
            return this.peps.Dequeue();
        }
        else if (this.tip == tipo.UEPS && this.tamaño > 0)
        {
            return this.ueps.Pop();
        }
        else
        {
            return new producto();
        }
    }

    public void agregarProducto(producto producto,int tip)
    {
        if (tip == tipo.UEPS)
        {
            this.ueps.Push(producto);
        }
        else if (tip == tipo.PEPS)
        {
            this.peps.Enqueue(producto);
        }
    }
    private void calcularPrecio()
    {
        for (var i = 0; i < valor.Count; i++)
        {
            precio = precio + valor[i].CostoPromedio;
        }
    }
    public void eliminarProducto(producto producto)
    {
        for (var i = 0; i< valor.Count; i++)
        {
            if (valor[i].Nombre == producto.Nombre)
            {
                valor.Remove(valor[i]);
            }
        }
    }
    public int Tipo { get => tip;}
    public List<producto> Valor { get => valor; set => valor = value; }
    public int Tamaño { get => tamaño;}
    public void setTamaño()
    {
        if (this.tip == tipo.PEPS)
        {
            this.tamaño = this.peps.Count();
        }
        else if (this.tip == tipo.UEPS)
        {
            this.tamaño = this.ueps.Count();
        }
    }
    public float Precio { get => precio; set => precio = value; }

}