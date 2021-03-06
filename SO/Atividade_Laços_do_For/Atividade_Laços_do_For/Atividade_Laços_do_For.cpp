#include "stdafx.h"
#include <omp.h>
#include <stdio.h>
#define SIZE 2

int main()
{
	/*
		Muitiplica as matrízes e guarda o resultados na matriz C
	*/
	
	int i, j, k;
	int A[2][2] = { { 1,2 },{ 3,4 } };
	int B[2][2] = { { 5,6 },{ 7,8 } };
	int C[2][2];
	int num = 0;

	omp_set_num_threads(4);
	#pragma omp parallel for private(i,j,k) shared(A,B,C)

	for (i = 0; i < SIZE; i++)
	{
		for (j = 0; j < SIZE; j++)
		{
			int soma = 0;
			for (k = 0; k < SIZE; k++)
			{
				soma += A[i][j] * B[k][j];
			}
			C[i][j] = soma;
		}
	}
	getchar();
	return 0;
}