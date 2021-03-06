#include "stdafx.h"
#include <omp.h>
#include <stdio.h>

int main()
{
	/*
		Imprime um número diferente do esperado por causa da sobrescrita de valores que acontecem
		de forma desordenada.
	*/
	
	int num = 0;
	omp_set_num_threads(70);
	#pragma omp parallel shared (num)
	{
		num++;
	}

	printf("Fim do processo x = %d\n", num);

	getchar();
	return 0;
}