//Dmitrii Kondratev
//COSC-1337
//Programming Assignment 1, problem 1

#include <stdio.h>
#include <iostream.h>
//adding 3 function prototypes for 3 different variants of program
void variant1();
void variant2();
void variant3();

int main()
{
    //starting all the function in sequence
  variant1();
  variant2();	
  variant3();
  //keep the screen, so user have some tiome to see the output
system("PAUSE");
return 0;	
}
//first function - output 4 numbers with 1 cout statement
void variant1()
{
 cout << "1 2 3 4" << endl;
}
//second function - output 4 values with 4 stream inputs
void variant2()
{
 cout << "1 " << "2 " << "3 " << "4" << endl;
}
//third function - output 4 numbers with 4 cout operators
void variant3()
{
 cout << "1 ";
 cout << "2 ";
 cout << "3 ";
 cout << "4" << endl;
}
//not sure, if i've understood the task correctly
