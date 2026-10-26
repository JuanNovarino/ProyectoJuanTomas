using PracticaPOO;

Producto producto1 = new Producto() { Nombre = "Coca cola", Id = 1 , Precio = 200.50m };
Producto producto2 = new Producto() { Nombre = "Pepsi", Id = 2 , Precio = 50.75m };


//punto 6
String informacionProductoUno = producto1.MostrarInfo();

Console.WriteLine(producto1.MostrarInfo());

Cliente cliente1 = new Cliente() { Nombre = "Feli", Id = 1, Email = "juan@gmail.com" };