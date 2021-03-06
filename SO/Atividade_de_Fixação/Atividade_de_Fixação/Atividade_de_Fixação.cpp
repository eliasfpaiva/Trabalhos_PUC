#include "stdafx.h"
#include <omp.h>

int main()
{
	/*
		As threads master e single só são executadas uma vez
		e a critical executa todas as threads
	*/
	
	int a = 0, b = 0, c = 0;
	omp_set_num_threads(50);

#pragma omp parallel shared(a,b,c)

	{
#pragma omp master
		a++;

#pragma omp single
		b++;

#pragma omp critical
		c++;
	}

	printf("master: %d; single: %d; critical: %d\n", a, b, c);

	getchar();
	return 0;
}