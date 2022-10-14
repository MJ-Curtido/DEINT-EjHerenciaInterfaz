// See https://aka.ms/new-console-template for more information

using Ej2;

Electrodomestico[] electrodomesticos = new Electrodomestico[10];

electrodomesticos[0] = new Electrodomestico();
electrodomesticos[1] = new Lavadora();
electrodomesticos[2] = new Television();
electrodomesticos[3] = new Electrodomestico(50, 15);
electrodomesticos[4] = new Lavadora(300, 200);
electrodomesticos[5] = new Television(600, 50);
electrodomesticos[6] = new Electrodomestico(399.99, Colores.AZUL, 'F', 0.2);
electrodomesticos[7] = new Electrodomestico();
electrodomesticos[8] = new Electrodomestico();
electrodomesticos[9] = new Electrodomestico();