# MouseOFF - TI VERDE | GREEN IT 

<h1> O Projeto </h1>
O Software MouseOFF foi desenvolvido com o objetivo de auxiliar as pessoas na economia de energia do dia a dia. 

<h1>Plataformas</h1>

<h5>Windows 7</h5>
<h5>Windows 8</h5>
<h5>Windows 8.1</h5>

<hr>

<h1> Métodos de Desenvolvimento </h1>
<h3>DESENVOLVIMENTO MOUSE OFF</h3>

	Começamos o desenvolvimento do programa Mouse off com um projeto de software, colocando todas ideias e tudo que o programa deveria ter no papel. 
	Depois disso, escolhemos a linguagem de programação C# (Csharp) como nosso ponto de partida na parte de layout e interação do software com o usuário (Front-End), assim criamos um simples formulário WINFORM contendo:
	<ul>
	<li>1 CAMPO NumericUpDown – Para escolher em quanto tempo o Mouse deve ser deligado. </li>
	<li>2 Botões Inputs – Para Ativar e Desativar  a contagem de tempo para o Mouse Desligar</li>
	<li>1 Input – Para desativar o Mouse a qualquer momento.<li>
	</ul>

Quando, o usuário clicar em qualquer botão deste WINFORM através da função ShellExec será executado nosso módulo da segunda camada que foi feito em linguagem C, passando através de Argumentos as determinadas funções que devem ser executadas pelo nosso Control, os argumentos válidos a ser executado pelo nosso Back-End, são eles: 
•	Ativar – Ativa o Mouse a qualquer momento
•	Desativar – Desativa o Mouse a qualquer momento
	Tempo X  - Tempo para o mouse desligar, Eg. Tempo 60,o mouse deligara após inatividade por 60 segundos.
Escolhemos a Linguagem C para ser nosso módulo de controle, pela fácil interação com os arquivos do SO. Em qualquer uma das tomadas de ação enviadas da linguagem de interação para a linguagem de controle será feita em Background e não será percebida pelo usuário. 
Depois que os argumentos são validados é executado para cada caso uma ação através do Utilitário de linha de comando DevCon.  O utilitário DevCon é um utilitário de linha comando que age como uma alternativa para o Gerenciador de dispositivos. Usando o DevCon, é possível ativar, desativar, reiniciar, atualizar, remover e consultar dispositivos individuais ou grupos de dispositivos. Pode ser encontrado e baixado no site da Microsoft.
Utilizamos apenas dois comandos do Devcon são eles:
•	enable - Ativa os dispositivos que correspondam ao hardware específico ou identificação de instância.
•	disable - Desativa os dispositivos que correspondam ao hardware específico ou identificação de instância.

Quando o argumento cada argumento é passado tratemos 1 solução diferente:
•	Ativar – passamos para o Devcon o comando:  enable *Mouse*
•	Desativar - passamos para o Devcon o comando:  disable *Mouse*
•	Tempo X – É executado uma função que espera o tempo determinado em X, caso haja alguma interação com o mouse a contagem é reiniciada. Caso o tempo acabe, retornara uma execução para desabilitar o mouse.

Considerações importantes do Desenvolvimento.
•	O programa ainda necessita de ter permissão de Administrador da máquina para desabilitar e habilitar os Drivers. 
•	A arquitetura do processador interfere em qual DevCon será utilizado, se será o apropriado para 32 bits ou 64 bits, essa validação é feita pelo nosso Control.
•	Toda vez que a função desabilitar for chamada o control enviara para o view um comando para uma mensagem de alerta ser exibida: Aperte qualquer tecla do teclado para habilitar o Mouse. 



