Console.WriteLine("=================================");
Console.WriteLine(" PROMEDIO DE NOTAS ");
Console.WriteLine("=================================");

int SumaNotas = 0;
int notaMayor = 0, j = 0;
double promedio;
int[] notas;
notas = new int[5];
string[] alumno;
alumno = new string[5];

Console.Write(" Ingrese el nombre del alumno: ");
alumno[0] = Console.ReadLine();

Console.Write(" Ingrese la nota: ");
notas[0] = int.Parse(Console.ReadLine());

Console.Write(" Ingrese el nombre del alumno: ");
alumno[1] = Console.ReadLine();

Console.Write(" Ingrese la nota: ");
notas[1] = int.Parse(Console.ReadLine());

Console.Write(" Ingrese el nombre del alumno: ");
alumno[2] = Console.ReadLine();

Console.Write(" Ingrese la nota: ");
notas[2] = int.Parse(Console.ReadLine());

Console.Write(" Ingrese el nombre del alumno: ");
alumno[3] = Console.ReadLine();

Console.Write(" Ingrese la nota: ");
notas[3] = int.Parse(Console.ReadLine());

Console.Write(" Ingrese el nombre del alumno: ");
alumno[4] = Console.ReadLine();

Console.Write(" Ingrese la nota: ");
notas[4] = int.Parse(Console.ReadLine());

Console.WriteLine("=================================");
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] >= 70)
        Console.WriteLine("La nota de {0} es de: {1}" , alumno[i], notas[i] + ", " + "por lo tanto aprobó.");
    else
    {
        Console.WriteLine("La nota de {0} es de: {1}", alumno[i], notas[i] + ", " + "por lo tanto reprobó.");

       
    }
    while (j < 5)
    {
        if (notas[j] > notaMayor)
            notaMayor = notas[j];
        j++;

        {

        }
    }
    SumaNotas = SumaNotas + notas[i];
}
promedio = SumaNotas / notas.Length;

Console.WriteLine("=================================");
Console.WriteLine("La suma de todas las notas es de: {0}" ,SumaNotas);
Console.WriteLine("=================================");
Console.WriteLine("El promedio de las notas es de: {0}" ,promedio);
Console.WriteLine("=================================");
Console.WriteLine("La nota mayor es de: {0}", notaMayor);
Console.WriteLine("=================================");


Console.ReadKey();




