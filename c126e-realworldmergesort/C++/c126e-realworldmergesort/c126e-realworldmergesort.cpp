// c126e-realworldmergesort.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <vector>
#include <iostream>

void MergeSort(std::vector<int> &a, std::vector<int> &b)
{
	for (int i = a.size() - 1; i >= 0; i--)
	{
		b[i] = a[i];
		for (int k = i; k < b.size() - 1; k++)
		{
			if (b[k] > b[k + 1])
			{
				int temp = b[k];
				b[k] = b[k + 1];
				b[k + 1] = temp;
			}
			else
				break;
		}
	}
}

int main()
{
	int aArr[] = { 692, 1, 32};
	int bArr[] = { 0, 0, 0, 14, 15, 123, 692, 2431 };
	std::vector<int> a(aArr, aArr + sizeof(aArr) / sizeof(aArr[0]));
	std::vector<int> b(bArr, bArr + sizeof(bArr) / sizeof(bArr[0]));
	MergeSort(a, b);
	std::cout << "List A: ";
	for each(int i in a)
	{
		std::cout << i << " ";
	}
	std::cout << "\nList B: ";
	for each(int i in b)
	{
		std::cout << i << " ";
	}
	int wait;
	std::cin >> wait;

	return 0;
}

