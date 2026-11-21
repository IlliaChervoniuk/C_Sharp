namespace C_Sharp_P58                  // простори імен групують класи
{
    internal class Program             // весь код групується у класах (методах)
    {                                  // поза класами код не створюється
        static void Main(string[] args) // першим запускається даний метод
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

/*
 Платформа Microsoft .NET та мова програмування C#
   C# (C-Sharp) - мова 4 покоління (4GL), що базується на платформі .NET
   Загальна ідея:
   програма мовою C# компілюється (транслюється) до проміжної мови
    MSIL (Microsoft Intermediate Language), схожою на Асемблер.
   Цей файл з проміжним кодом є виконавчим (.exe) і опрацьовується
   платформою, яка "на льоту" (just in time, JIT) докомпільовує його
   до процесорного коду, який реально виконується.
   
   JScript------\        |    |
   VisualBasics--\       |.NET|
   C# (text) --> MSIL -->|JIT |---> CPU
   F# ----------/        |CLR |
   C++.NET ----/         |    |
                        Managed     Unmanaged
        
   Така схема виконання дозволяє зробити мову програмування придатною 
   для різних операційних платформ (Windows, Linux, Mac, Android тощо) 
   для яких випускаються різні збірки .NET, які приймають однакові програми.
   
   IDE = Integrated Development Equipment 
        Microsoft Visual Studio
        JetBrains Rider
        Mono
        VS Code 

    CLR - Comon Language Runtime
    JIT - Just In Time Compiler - IL to CPU
    FCL - Framework Class Library  
*/