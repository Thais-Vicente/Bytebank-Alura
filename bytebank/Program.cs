using bytebank;

ContaCorrente contaDeMarcos = new ();
contaDeMarcos.titular = "Marcos Vieira";
contaDeMarcos.agencia = 20;
contaDeMarcos.conta = "3515-X";
contaDeMarcos.saldo = 100;
Console.WriteLine("Saldo na conta de Marcos =" + contaDeMarcos.saldo);

ContaCorrente contaDeMarcos2 = new ();
contaDeMarcos2.titular = "Marcos Vieira";
contaDeMarcos2.agencia = 20;
contaDeMarcos2.conta = "3515-X";
contaDeMarcos2.saldo = 100;
Console.WriteLine("Saldo na conta de Marcos =" + contaDeMarcos2.saldo);

contaDeMarcos = contaDeMarcos2;

Console.WriteLine(contaDeMarcos==contaDeMarcos2);

//ContaCorrente contaDeLuciana = new ();
//contaDeLuciana.titular = "Lucina Silva";
//contaDeLuciana.agencia = 30;
//contaDeLuciana.conta = "1267-3";
//contaDeLuciana.saldo = 400;

//Console.WriteLine("Saldo na conta de Luciana =" + contaDeLuciana.saldo);

//contaDeMarcos.Transferir(70, contaDeLuciana);
//Console.WriteLine("Saldo de Marcos = " + contaDeMarcos.saldo);
//Console.WriteLine("Saldo de Luciana = " + contaDeLuciana.saldo);

//ContaCorrente contaDeJoao = new ();
//contaDeJoao.titular = "Joao Amorim";
//Console.WriteLine(contaDeJoao.titular);
//Console.WriteLine(contaDeJoao.saldo);
//Console.WriteLine(contaDeJoao.agencia);
//Console.WriteLine(contaDeJoao.conta);




