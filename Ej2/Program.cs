// See https://aka.ms/new-console-template for more information

using Ej2;

Electrodomestico[] electrodomesticos = new Electrodomestico[10];

electrodomesticos[0] = new Lavadora();
electrodomesticos[1] = new Lavadora();
electrodomesticos[2] = new Television();
electrodomesticos[3] = new Television(50, 15);
electrodomesticos[4] = new Lavadora(300, 200);
electrodomesticos[5] = new Television(600, 50);
electrodomesticos[6] = new Lavadora(5, 399.99, Colores.AZUL, 'F', 0.2);
electrodomesticos[7] = new Lavadora(25, 399.99, Colores.AZUL, 'F', 0.2);
electrodomesticos[8] = new Television(27, true, 399.99, Colores.AZUL, 'F', 0.2);
electrodomesticos[9] = new Television();

Double sumaLavadora = 0, sumaTelevision = 0, sumaElectrodomesticos = 0;

foreach (var electrodomestico in electrodomesticos)
{
	electrodomestico.PrecioFinal();

	if (electrodomestico is Lavadora)
	{
		sumaLavadora += electrodomestico.PrecioBase;
	}
	else
	{
		sumaTelevision += electrodomestico.PrecioBase;
	}

	sumaElectrodomesticos += electrodomestico.PrecioBase;
}

Console.WriteLine($"Suma de todas las televisiones: {sumaTelevision}€");
Console.WriteLine($"Suma de todas las lavadoras: {sumaLavadora}€");
Console.WriteLine($"Suma de todos los electrodomésticos: {sumaElectrodomesticos}€");