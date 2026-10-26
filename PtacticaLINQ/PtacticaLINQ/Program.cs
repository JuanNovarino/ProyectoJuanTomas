List<int> numeros = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86, 153, 15, 67, 92 };

List<string> palabras = new List<string>
{
    "computadora", "usb", "ventilador", "reloj", "buscador",
    "estudiar", "caminar", "dia", "monitor", "teclado"
};

List<int> conRepetidos = new List<int> { 5, 3, 8, 3, 1, 5, 9, 8, 5 };

List<string> frases = new List<string>
{
    "el gato duerme",
    "la casa es grande",
    "programar es divertido"
};

var resultado1 = numeros.Where(n => n > 30 && n < 100);
Console.WriteLine($"{resultado1}");