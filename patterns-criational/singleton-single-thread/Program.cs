﻿using singleton_single_thread;

Console.WriteLine("##### Padrão Singleton #####\n");
Console.WriteLine("Tentando criar uma instância s1.");
Singleton s1 = Singleton.Instance;
Console.WriteLine("Tentando criar uma instância s2");
Singleton s2 = Singleton.Instance;
if (s1 == s2)
    Console.WriteLine("Existem somemnte uma instância");
else {
    Console.WriteLine("Existyem instâncias diferentes (s1 e s2)");
}