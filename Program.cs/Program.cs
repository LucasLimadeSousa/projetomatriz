var a = new Matriz(3, 3);
var b = new Matriz(2, 2);

a.setValorMatriz(0,0,1);
a.setValorMatriz(0,1,2);
a.setValorMatriz(0,2,5);
a.setValorMatriz(1,0,3);
a.setValorMatriz(1,1,4);
a.setValorMatriz(1,2,6);
a.setValorMatriz(2,0,7);
a.setValorMatriz(2,1,8);
a.setValorMatriz(2,2,9);

Matriz.mostrarMatriz(a.Elementos);
Console.WriteLine("\n");




b.setValorMatriz(0, 0, 1);
b.setValorMatriz(0, 1, 2);
b.setValorMatriz(1, 0, 5);
b.setValorMatriz(1, 1, 3);


Matriz.mostrarMatriz(AlgebraLinear.gauss(a.Elementos));

