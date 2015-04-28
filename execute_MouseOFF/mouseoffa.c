#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include <Windows.h>
#include <ShellApi.h>
#include <dos.h>

void devcon(int ed);
void arg_error();
void cont(int tempo);

/*	PARAMETROS DE ARGUMENTOS VALIDOS
	ativar - Ativar o mouse
	desativar	- Desativar o Mouse
	tempo	X - Tempo para desativar o mouse em s eg. tempo 60
*/
void main(int argc, char *argv[]){
	
	int time;
	
	if(argc == 1 || argc > 3)
		arg_error();
		
	if(strcmp (argv[1],"ativar") == 0)
		devcon(1);
		
	else if(strcmp (argv[1],"desativar") == 0)
		devcon(0);
		
	else if(strcmp (argv[1],"tempo") == 0){
		if(argc < 3)
			arg_error();
		
		time = atoi(argv[2]);// Transforma o tempo em inteiro
		
		if(time <=0 )
			arg_error(); 
		 
		cont(time); //esperar o tempo
		devcon(0); //Desativar Mouse
		
	}
	
	else
		arg_error();
	
	
}

/*********** FUNCOES ******************/

/*
	enable e disable mouse devcon
	params: int ed; 1 ou 0
	Vai desabilitar ou habilitar a classe de *MOUSE*
*/
void devcon(int ed){
	if(ed) //se for 1 enable 
		ShellExecute(NULL, "open", "devcon", "enable *MOUSE*", "devcon\\ia64\\", SW_HIDE ); 	 
	else //se for 0 disable
		ShellExecute(NULL, "open", "devcon", "disable *MOUSE*", "devcon\\ia64\\", SW_HIDE );	
	
}



/* CONTADOR REGRESSIVO
	Faz a contagem de 1 em 1 segundo regressivamente
	e coloca o tempo novamente o inicial a cada interaçao com
	o mouse
*/
void cont(int tempo){
	int cont = tempo;
	
	while(cont > 0){
		printf(" %d \n", cont);
		cont--;
		Sleep(1000);
	}
	
}

/* ERROR ARGUMENT
	Se o argumento passado for invalido retornar este erro;
*/
void arg_error(){
	printf("ARGUMENTOS PASSADOS INVALIDOS\n");
	system("pause");
	exit(1);
}
	
