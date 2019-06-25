// sum_arr1.c -- sums the elements of an array
// use %u or %lu if %zd doesn't work

#include "pch.h"
#include <iostream>
#define SIZE 10

int sum(int ar[], int n);
int main(void)
{
	int marbles[SIZE] = { 20,10,5,39,4,16,19,26,31,20 };
	long answer;

	answer = sum(marbles, SIZE);
	printf_s("The total number of marbles is %ld.\n", answer);
	printf_s("The size of marbles is %u bytes.\n",
		sizeof marbles);

	return 0;
}

int sum(int ar[], int n)     // how big an array?
{
	int i;
	int total = 0;

	for (i = 0; i < n; i++)
		total += ar[i];
	printf_s("The size of ar is %u bytes.\n", sizeof ar);

	return total;
}
