﻿/* Инфо и реализация

    * Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует, что для определенного 
      класса будет создан только один объект, а также предоставит к этому объекту точку доступа.

    * Когда надо использовать Синглтон? Когда необходимо, чтобы для класса существовал только один экземпляр

    * Синглтон позволяет создать объект только при его необходимости. Если объект не нужен, 
      то он не будет создан. В этом отличие синглтона от глобальных переменных.

    * Классическая реализация данного шаблона проектирования на C# выглядит следующим образом:
      
        class Singleton
        {
            private static Singleton instance;
 
            private Singleton()
            {}
 
            public static Singleton getInstance()
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

    * В классе определяется статическая переменная - ссылка на конкретный экземпляр данного объекта 
      и приватный конструктор. В статическом методе getInstance() этот конструктор вызывается для 
      создания объекта, если, конечно, объект отсутствует и равен null.

    * Для применения паттерна Одиночка создадим небольшую программу. Например, на каждом компьютере можно 
      одномоментно запустить только одну операционную систему. В этом плане операционная система будет 
      реализоваться через паттерн синглтон:
*/

using OperatingSystemLib.Classes;

namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        Computer comp = new Computer();
        comp.Launch("Windows 8.1");
        Console.WriteLine(comp.OS.Name);

        // у нас не получится изменить ОС, так как объект уже создан    
        comp.OS = OS.getInstance("Windows 10");
        Console.WriteLine(comp.OS.Name);

        Console.ReadLine();
    }
}