# MouseOFF - TI VERDE | GREEN IT 

<h1> O Projeto </h1>
O Software MouseOFF foi desenvolvido com o objetivo de auxiliar as pessoas na economia de energia do dia a dia. 

<h1>Plataformas</h1>

<h5>Windows 7</h5>
<h5>Windows 8</h5>
<h5>Windows 8.1</h5>

<hr>

<h1> M�todos de Desenvolvimento </h1>


DESENVOLVIMENTO MOUSE OFF

Come�amos o desenvolvimento do programa Mouse off com um projeto de software, colocando todas ideias e tudo que o programa deveria ter no papel. 
Depois disso, escolhemos a linguagem de programa��o C# (Csharp) como nosso ponto de partida na parte de layout e intera��o do software com o usu�rio (Front-End), assim criamos um simples formul�rio WINFORM contendo:
�	1 CAMPO NumericUpDown � Para escolher em quanto tempo o Mouse deve ser deligado. 
�	2 Bot�es Inputs � Para Ativar e Desativar  a contagem de tempo para o Mouse Desligar
�	1 Input � Para desativar o Mouse a qualquer momento.
Quando, o usu�rio clicar em qualquer bot�o deste WINFORM atrav�s da fun��o ShellExec ser� executado nosso m�dulo da segunda camada que foi feito em linguagem C, passando atrav�s de Argumentos as determinadas fun��es que devem ser executadas pelo nosso Control, os argumentos v�lidos a ser executado pelo nosso Back-End, s�o eles: 
�	Ativar � Ativa o Mouse a qualquer momento
�	Desativar � Desativa o Mouse a qualquer momento
	Tempo X  - Tempo para o mouse desligar, Eg. Tempo 60,o mouse deligara ap�s inatividade por 60 segundos.
Escolhemos a Linguagem C para ser nosso m�dulo de controle, pela f�cil intera��o com os arquivos do SO. Em qualquer uma das tomadas de a��o enviadas da linguagem de intera��o para a linguagem de controle ser� feita em Background e n�o ser� percebida pelo usu�rio. 
Depois que os argumentos s�o validados � executado para cada caso uma a��o atrav�s do Utilit�rio de linha de comando DevCon.  O utilit�rio DevCon � um utilit�rio de linha comando que age como uma alternativa para o Gerenciador de dispositivos. Usando o DevCon, � poss�vel ativar, desativar, reiniciar, atualizar, remover e consultar dispositivos individuais ou grupos de dispositivos. Pode ser encontrado e baixado no site da Microsoft.
Utilizamos apenas dois comandos do Devcon s�o eles:
�	enable - Ativa os dispositivos que correspondam ao hardware espec�fico ou identifica��o de inst�ncia.
�	disable - Desativa os dispositivos que correspondam ao hardware espec�fico ou identifica��o de inst�ncia.

Quando o argumento cada argumento � passado tratemos 1 solu��o diferente:
�	Ativar � passamos para o Devcon o comando:  enable *Mouse*
�	Desativar - passamos para o Devcon o comando:  disable *Mouse*
�	Tempo X � � executado uma fun��o que espera o tempo determinado em X, caso haja alguma intera��o com o mouse a contagem � reiniciada. Caso o tempo acabe, retornara uma execu��o para desabilitar o mouse.

Considera��es importantes do Desenvolvimento.
�	O programa ainda necessita de ter permiss�o de Administrador da m�quina para desabilitar e habilitar os Drivers. 
�	A arquitetura do processador interfere em qual DevCon ser� utilizado, se ser� o apropriado para 32 bits ou 64 bits, essa valida��o � feita pelo nosso Control.
�	Toda vez que a fun��o desabilitar for chamada o control enviara para o view um comando para uma mensagem de alerta ser exibida: Aperte qualquer tecla do teclado para habilitar o Mouse. 



