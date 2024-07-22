using FactoryMethod;

Console.WriteLine("Factory Method Pattern");

//Instância a classe Fábrica
FactoryTransport factory = new FactoryTransport();

/**Valores possíveis
ar
agua
terra**/
var transporte = factory.CreateTransporte("ar");

transporte.Transportar();

Console.ReadLine();



