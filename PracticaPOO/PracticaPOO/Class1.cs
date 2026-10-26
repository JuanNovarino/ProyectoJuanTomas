using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;

namespace PracticaPOO;
public class Producto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Precio { get; set; }
    public bool Activo { get; set; }

  //punto 3
    public Producto()
    {
        Activo = true ; 
    }

   //punto 4 y 5 
   public Producto(int id, string? nombre, decimal precio)
    {
        if ((precio > 0) && (nombre != null) && (nombre!= ""))
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
        else
        {
            
        }
     
    }
    //punto 6 : creación de metodo

    public string MostrarInfo()
    {
        String textoDatosProducto = $"Datos del producto: {Id}, {Nombre}, {Precio}, {Activo}";

        return textoDatosProducto;
    }
    
}
public class Cliente
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Email { get; set; }

    public Cliente(int id, string? nombre, string email)
    {

        Id = id;
        Nombre = nombre;
        Email = email;


    }
}