#include <stdio.h>

void variant1();
void variant2();
void variant3();

int main()
{
  variant1();
	variant2();	
	variant3();
	System("PAUSE");
`	return 0;	
}

void variant1()
{
	cout << "1 2 3 4" << endl;
}
void variant2()
{
	cout << "1 " << "2 " << "3 " << "4" << endl;
}
void variant3()
{
	cout << "1 ";
	cout << "2 ";
	cout << "3 ";
	cout << "4" << endl;
}
