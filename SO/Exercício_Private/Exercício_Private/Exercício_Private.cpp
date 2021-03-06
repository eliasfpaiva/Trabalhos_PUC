#include "stdafx.h"
#include <omp.h>
#include <stdio.h>

int main()
{
	/*
		Imprime 4 vezes as saidas
	*/
	int num = 100;
	omp_set_num_threads(4);
	#pragma omp parallel firstprivate (num)
	{
		printf("Inicio da thread, x = %d\n", num);
		num = 500;
		printf("Fim da thread, x = %d\n", num);
	}

	printf("O valor final de x é %d\n", num);

	getchar();
	return 0;
}