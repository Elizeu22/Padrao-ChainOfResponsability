

using ChainOfResponsability;

Gerente gerente = new Gerente();
Diretor diretor = new Diretor();
Presidente presidente = new Presidente();


gerente.DefinirProximo(diretor);
diretor.DefinirProximo(presidente);


gerente.proximoFunc(100);

diretor.proximoFunc(2000);

presidente.proximoFunc(50000);
