// Hello World.cpp : define o ponto de entrada para o aplicativo do console.
//

#include "stdafx.h"
#include <omp.h>

int main()
{
	omp_set_num_threads(40);
	#pragma omp parallel
	{
		printf("Hello world!\n");
	}
	getchar();
	return 0;
}