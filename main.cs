/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
    static void SwitchFinger(int fingers){
        switch (fingers)
        {
            case 1:
            Console.WriteLine("Большой палец!");
            break;
            
            case 2:
            Console.WriteLine("Указательный палец!");
            break;
            
            case 3:
            Console.WriteLine("Средний палец!");
            break;
            
            case 4:
            Console.WriteLine(" безимянный палец!");
            break;
            
            case 5:
            Console.WriteLine("Мизинец ");
            break;
            
            default:
            Console.WriteLine("Введите число от 1 до 5");
            break;
        }
    }
  static void Main() {
    
    Console.Write("Введите число для определения:");
    int fingers = Convert.ToInt32(Console.ReadLine());
    
    int finger1 = fingers % 10;
    int finger2 = fingers / 10;
    
    
    HelloWorld.SwitchFinger(finger1);
    HelloWorld.SwitchFinger(finger2);
  }
}
