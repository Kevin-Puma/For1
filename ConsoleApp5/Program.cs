    Console.Write("Ingrese un numero limite: ");
    int limite =  int.Parse(Console.ReadLine());
    int suma = 0;
    Console.Write("Los numeros pares son: ");
    for (int i = 1; i <= limite; i++)
    {
        if (i % 2==0) 
        {
            Console.Write(i+ ", ");
            suma = suma + i;
        } 
    }
    Console.WriteLine();
    Console.WriteLine("La suma es:"+suma);
    Console.ReadKey();    

    




    
