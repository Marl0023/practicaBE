int suma = 0;
do {
    suma = 0;
    Console.WriteLine("Ingrese un numero: ");
    int num= int.Parse(Console.ReadLine());
    for (int i = 1; i <= num; i++) {
        suma += i;
    }
    Console.WriteLine($"La suma desde el numero  1 hasta el numero {num}: {suma}");
    Console.WriteLine("Desea continuar ? (S/N)");
    char resp = char.Parse(Console.ReadLine().ToUpper());
    if (resp == 'N') {
        break;
    }
}while (true);