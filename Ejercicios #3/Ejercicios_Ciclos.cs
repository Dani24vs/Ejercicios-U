/* #Ejercicio 1. Cuenta regresiva para un evento
int Numero, Paso;
Console.Write("¿Desde Que Numero Empieza La Cuenta?: ");
Numero = int.Parse(Console.ReadLine());
Console.Write("¿De Cuanto En Cuanto Baja?: ");
Paso = int.Parse(Console.ReadLine());
if (Numero > 0)
{
    if (Paso > 0 && Paso < Numero)
    {
        for (int i = Numero; i > 0; i -= Paso)
        {
            Console.Write(i + " ");
        }
    }
}
Console.WriteLine();
Console.WriteLine("¡Comienza El Evento!");
*/

/* #Ejercicio 2. Pares e impares entre 1 y N 
int N, ContPar = 0, ContImpa = 0, AcumPar = 0 , AcumImpa = 0;
Console.Write("Ingrese El Numero : ");
N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
     ContPar++;
     AcumPar+=i;
    }
  else
    {
      ContImpa++;
      AcumImpa+=i;
    }
}
Console.WriteLine("Pares: " + ContPar + "(Suman: " + AcumPar + ")" );
Console.WriteLine("Impares: " + ContImpa + "(Suman: " + AcumImpa + ")" ); 
*/

/* #Ejercicio 3. Ahorro programado
 decimal Meta, AporteM, MesesN = 0, SaldoF = 0m;
const decimal InteresM = 0.008m;
Console.Write("Meta De Ahorro: ");
Meta = decimal.Parse(Console.ReadLine());
Console.Write("Aporte Mensual: ");
AporteM = decimal.Parse(Console.ReadLine());
while (SaldoF < Meta)
{
  SaldoF += SaldoF * InteresM;
  SaldoF += AporteM;
  MesesN++;
}
Console.WriteLine("Meses Necesarios: " + MesesN);
Console.WriteLine("Saldo Final: " + SaldoF);
*/

/* #Ejercicio 4. Clave de acceso con tres intentos 
string Clave = "luis2026", Contraseña;
int Intentos = 0;
do
{
  Console.Write("Clave: ");
  Contraseña = Console.ReadLine().Trim().ToLower();
  if (Contraseña != Clave)
  {
    Intentos++;
    Console.WriteLine("Clave Incorrecta. Intentos Restantes: " + (3 - Intentos));
    Console.WriteLine("Acceso Denegado");
  }
  else
  {
    Console.WriteLine("Acceso Concedido.");
  }
} while (Intentos < 3 && Contraseña != Clave);
*/

/* Fallo
int Contador = 0, Acumulador = 0, Mayor, Menor, Aprobado, Reprobado;
double Promedio, Notas;
while (true)
{
  Notas = LeerNota("Nota (0 A 5, F Para Terminar): ");
  if (Notas == "F")
  {
    Contador++;
    Acumulador += Notas;
    if (Contador > 0)
    {
      Promedio = Acumlador / Contador;
      Console.WriteLine("Notas: " + Contador);
      Console.WriteLine("Promedio: " + Promedio);
    }
  }
  break;
}
static double LeerNota(string Mensaje)
{
  double Nota;
  Console.Write(Mensaje);
  while(!double.TryParse(Console.ReadLine(), out Nota) || Nota < 0.0 || Nota > 5.0)
  {
    Console.Write("Nota Invalido.");
    Console.Write("Ingrese Otra Nota (0 A 5)");
  }
  return Nota;
}
*/

/* #Ejercicio 5. Estadísticas de notas con centinela
int Contador = 0, Aprobado = 0, Reprobado = 0;
double Acumulador = 0, Notas, Mayor = 0, Menor = 0, Promedio;
while (true)
{
    Notas = LeerNota("Nota (0 a 5, F para terminar): ");
    if (Notas == -1)
        break;
    Contador++;
    Acumulador += Notas;
    if (Contador == 1)
    {
        Mayor = Notas;
        Menor = Notas;
    }
    else
    {
        if (Notas > Mayor)
            Mayor = Notas;
        if (Notas < Menor)
            Menor = Notas;
    }
    if (Notas >= 3.0)
        Aprobado++;
    else
        Reprobado++;
}

if (Contador > 0)
{
    Promedio = Acumulador / Contador;
    Console.WriteLine("\nNotas: " + Contador);
    Console.WriteLine("Promedio: " + Promedio.ToString("F2"));
    Console.WriteLine("Mayor: " + Mayor);
    Console.WriteLine("Menor: " + Menor);
    Console.WriteLine("Aprobados: " + Aprobado);
    Console.WriteLine("Reprobados: " + Reprobado);
}
else
{
  Console.WriteLine("No Se Ingresaron Notas.");
}
static double LeerNota(string Mensaje)
{
    double Nota;
    string Entrada;
    while (true)
    {
        Console.Write(Mensaje);
        Entrada = Console.ReadLine().Trim().ToLower();
        if (Entrada == "f")
            return -1;
        if (!double.TryParse(Entrada, out Nota) || Nota < 0.0 || Nota > 5.0)
        {
            Console.WriteLine("Nota Invalida.");
            continue;
        }
        return Nota;
    }
}
*/

/* #Ejercicio 6. Adivina el número
int Secreto = Random.Shared.Next(1, 101);
int Numero;
bool Acerto = false;

for (int i = 1; i <= 7; i++)
{
    Console.Write("Intento {i} De 7. Número (1 a 100): ");

    if (!int.TryParse(Console.ReadLine(), out Numero) || Numero < 1 || Numero > 100)
    {
        Console.WriteLine("Dato Inválido.");
        i--;
        continue;
    }

    if (Numero == Secreto)
    {
        Console.WriteLine("¡Correcto! Lo Lograste En " + i + " Intentos.");
        Acerto = true;
        break;
    }
    else if (Numero < Secreto)
    {
        Console.WriteLine("Es Mayor.");
    }
    else
    {
        Console.WriteLine("Es Menor.");
    }
}

if (!Acerto)
{
    Console.WriteLine("Se Acabaron Los Intentos.");
    Console.WriteLine("El Número Era: " + Secreto);
}
*/

/* #Ejercicio 7. Caja de la cafetería
using System.Globalization;

decimal Total = 0, Precio, Subtotal, Descuento;
int Opcion, Cantidad, Productos = 0;
CultureInfo Cultura = new CultureInfo("es-CO");
do
{
    Console.WriteLine("\n========== CAFETERÍA ==========");
    Console.WriteLine("1. Café - $3.500");
    Console.WriteLine("2. Empanada - $2.800");
    Console.WriteLine("3. Jugo - $4.200");
    Console.WriteLine("4. Ver Cuenta");
    Console.WriteLine("0. Pagar Y Salir");
    Console.Write("Opción: ");
    if (!int.TryParse(Console.ReadLine(), out Opcion))
    {
        Console.WriteLine("Opción inválida.");
        continue;
    }
    switch (Opcion)
    {
        case 1:
        case 2:
        case 3:
            Precio = Opcion switch
            {
                1 => 3500m,
                2 => 2800m,
                3 => 4200m,
                _ => 0m
            };
            Console.Write("Cantidad: ");
            if (!int.TryParse(Console.ReadLine(), out Cantidad) || Cantidad <= 0)
            {
                Console.WriteLine("Cantidad Inválida.");
                break;
            }
            Total += Precio * Cantidad;
            Productos += Cantidad;
            Console.WriteLine("Agregado.");
            Console.WriteLine("Subtotal: " + Total.ToString("C0", Cultura));
            break;
        case 4:
            Console.WriteLine("Productos: " + Productos);
            Console.WriteLine("Subtotal: " + Total.ToString("C0", Cultura));
            break;
        case 0:
            Subtotal = Total;
            if (Productos >= 5)
                Descuento = Subtotal * 0.10m;
            else
                Descuento = 0m;
            Console.WriteLine("Subtotal: " + Subtotal.ToString("C0", Cultura));
            Console.WriteLine("Descuento: " + Descuento.ToString("C0", Cultura));
            Console.WriteLine("Total A Pagar: " + (Subtotal - Descuento).ToString("C0", Cultura));
            Console.WriteLine("Gracias Por Su Compra.");
            break;
        default:
            Console.WriteLine("Opción Inexistente.");
            break;
    }
} while (Opcion != 0);
*/