using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitários;

CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Desenvolvedor ana = new Desenvolvedor("352.893.092-33");
    ana.Nome = "Ana";

    Designer pedro = new Designer("833.222.923-02 ");
    pedro.Nome = "Pedro";

    Diretor paula = new Diretor("229.476.153-04");
    paula.Nome = "Paula";

    Auxiliar carlos = new Auxiliar("481.539.043-99");
    carlos.Nome = "Carlos";

    GerenteDeContas roberto = new GerenteDeContas("087.444.520-03");
    roberto.Nome = "Roberto";


    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(carlos);
    gerenciador.Registrar(roberto);
    gerenciador.Registrar(ana);

    Console.WriteLine("Total de Bonificação: " +gerenciador.GetBonificacao);
}
Console.ReadKey();


