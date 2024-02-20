#include <stdio.h>

int main(void)
{
	for (int i = 0; i < 40; i++)
		printf("%02d %04x %x\n", i, i);

	return 0;
}
