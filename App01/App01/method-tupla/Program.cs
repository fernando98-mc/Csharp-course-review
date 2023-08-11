


// OBJETIVO : Registrar un nuevo producto en una tienda
// 1 - EL usuario ingresa la data del producto como nombre, precio, stock
// 2 - El programa va a capturar la data y procedera a poner un precio de venta 
//     que incluya el costo del impuesto del producto
// 3 - El metodo de registro del producto debe devolvwe la data del producto
// 4 - El programa debe imprimir la data del producto registrado



Console.WriteLine("Ingresa el nombre del producto");
var nameProduct = Console.ReadLine()!;

Console.WriteLine("Ingresa el precio del producto");
var priceProduct = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ingresa el stock de producto");
var stockProduct = int.Parse(Console.ReadLine()!); ;

//      TUPLA                                       // PARAMETROS METODO
(double, int, string) GetProductoData(string productName, int productPrice, int productStock)
{
    var priceFinal = productPrice + productPrice * 0.2;

    return (priceFinal, productStock, productName); // datos en orden de la tupla
}

var tuplaProductData = GetProductoData(nameProduct, priceProduct, stockProduct); // recibe lo datos en orden del metodo

//                                          datos en orden de la tupla
Console.WriteLine($"El nombre del producto es : {tuplaProductData.Item3} " +
                  $"\n El precio del producto es : {tuplaProductData.Item1}" +
                  $"\n El stock del producto es : {tuplaProductData.Item2}");