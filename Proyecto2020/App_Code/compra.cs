using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for compra
/// </summary>
public class compra
{
    private int numero;
    private string serie;
    private float total;
    private List<producto> producto;
    private static int contador = 0;
    public compra(float total,List<producto> producto)
    {
        generarNumero();
        this.serie = "u002";
        this.total = total;
        this.producto = producto;
    }

    private void generarNumero()
    {
        this.numero = contador;
        contador += 1;
    }
}