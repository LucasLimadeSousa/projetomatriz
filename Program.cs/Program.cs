Matriz bleh = new Matriz(3,1);

bleh.setValorMatriz(0,0,3);
bleh.setValorMatriz(1,0,4);
bleh.setValorMatriz(2,0,9);

var titioAvo = AlgebraLinear.times(5, bleh.Elementos);

Matriz.mostrarMatriz(titioAvo);
