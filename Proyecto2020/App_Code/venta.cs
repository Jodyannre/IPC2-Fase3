using DataSetHelloWorldTableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for venta
/// </summary>
public class venta
{
    private int numero;
    private string serie;
    private float total;
    private List<producto> productos;
    private estante ubicacion;
    private static int contador=0;
    public venta(float total,List<producto> productos,estante ubicacion)
    {
        generarNumero();
        this.serie = "v0032";
        this.total = total;
        this.ubicacion = ubicacion;
        this.productos = productos;
    }

    public int Numero { get => numero; set => numero = value; }
    public string Serie { get => serie; set => serie = value; }
    public float Total { get => total; set => total = value; }
    public List<producto> Productos { get => productos; set => productos = value; }
    public estante Ubicacion { get => ubicacion; set => ubicacion = value; }

    private void generarNumero()
    {
        this.numero = contador;
        contador++;
    }

}