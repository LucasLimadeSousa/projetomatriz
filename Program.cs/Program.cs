var b = new Matriz(3, 4);

b.setValorMatriz(0, 0, 3);
b.setValorMatriz(0, 1, 3);
b.setValorMatriz(0, 2, 6);
b.setValorMatriz(0, 3, 15);
b.setValorMatriz(1, 0, 0);
b.setValorMatriz(1, 1, 2);
b.setValorMatriz(1, 2, 2);
b.setValorMatriz(1, 3, 6);
b.setValorMatriz(2, 0, 0);
b.setValorMatriz(2, 1, 0);
b.setValorMatriz(2, 2, 3);
b.setValorMatriz(2, 3, 3);

Matriz.mostrarMatriz(AlgebraLinear.solve(b.Elementos));

