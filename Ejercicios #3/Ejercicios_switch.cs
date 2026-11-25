/* #Ejercicio 1. Nombre y días del mes
int Mes;
Console.Write("Ingrese El Numero Del Mes (1 A 12): ");     // Aja Moto Que
Mes = int.Parse(Console.ReadLine());
switch (Mes)
{
    case 1: 
     Console.WriteLine("Enero - 31 Dias.");
    break;
    case 2: 
     Console.WriteLine("Febrero - 28 Dias (29 En Año Bisiesto).");
    break;
    case 3: 
     Console.WriteLine("Marzo - 31 Dias.");
    break;
    case 4: 
     Console.WriteLine("Abril - 30 Dias.");
    break;
    case 5: 
     Console.WriteLine("Mayo - 31 Dias.");
    break;
    case 6: 
     Console.WriteLine("Junio - 30 Dias.");
    break;
    case 7: 
     Console.WriteLine("Julio - 31 Dias.");
    break;
    case 8: 
     Console.WriteLine("Agosto - 31 Dias.");
    break;
    case 9: 
     Console.WriteLine("Septiembre - 30 Dias.");
    break;
    case 10: 
     Console.WriteLine("Octubre - 31 Dias.");
    break;
    case 11: 
     Console.WriteLine("Noviembre - 30 Dias.");
    break;
    case 12: 
     Console.WriteLine("Diciembre - 31 Dias.");
    break;
    default:
     Console.WriteLine("No Se Ingreso Ningun Dato.");
    break;
}
*/

/* #Ejercicio 2. Descuento de matrícula por estrato
string Nombre;
const decimal Matricula = 3500000;
int Estrato;
decimal TotalPagar, Descuento;
Console.Write("Ingrese Su Nombre: ");
Nombre = Console.ReadLine();
Console.Write("Ingrese El Estrato (1 A 6): ");
Estrato = int.Parse(Console.ReadLine());
switch (Estrato)
{
    case 1:
     Descuento = Matricula * 0.50m;
     TotalPagar = Matricula - Descuento;
     Console.WriteLine("Estudiante: " + Nombre);
     Console.WriteLine("Descuento: 50% = " + Descuento);
     Console.WriteLine("Total A Pagar: " + TotalPagar);                      // Aqui Tambien Pude Solo Concatenar Solo Descuento JAJSJSJ.
    break;
    case 2:
     Descuento = Matricula * 0.40m;
     TotalPagar = Matricula - Descuento;
     Console.WriteLine("Estudiante: " + Nombre);
     Console.WriteLine("Descuento: 40% = " + Descuento);
     Console.WriteLine("Total A Pagar: " + TotalPagar);
    break;
    case 3:
     Descuento = Matricula * 0.25m;
     TotalPagar = Matricula - Descuento;
     Console.WriteLine("Estudiante: " + Nombre);
     Console.WriteLine("Descuento: 25% = " + Descuento);
     Console.WriteLine("Total A Pagar: " + TotalPagar);
    break;
    case 4:
     Descuento = Matricula * 0.10m;
     TotalPagar = Matricula - Descuento;
     Console.WriteLine("Estudiante: " + Nombre);
     Console.WriteLine("Descuento: 10% = " + Descuento);
     Console.WriteLine("Total A Pagar: " + TotalPagar);
    break;
    case 5:
    case 6:
     Console.WriteLine("Estudiante: " + Nombre);
     Console.WriteLine("Descuento: 0%.");
     Console.WriteLine("Total A Pagar: " + Matricula);
    break;
    default:
     Console.WriteLine("No Se Ingreso Dato Valido.");
    break;
}

// decimal y double no se pueden mezclar directamente en operaciones matemáticas.    Esto Me Lo Dijo ChatGPT, Eso Codigo Casi Que No Compila JAJJS.
// Los valores decimales deben llevar 'm' (Ej: 0.50m).
*/

/* #Ejercicio 3. Jornada según el día 
string Dia;
Console.Write("Dia De La Semana: ");
Dia = Console.ReadLine().Trim().ToLower();
string Jornada = Dia switch
{
    "lunes" or "martes" or "miercoles" or "jueves" or "viernes" => "Dia Habil: Hay Clases.",    // Si Quiero Devolver Valores Tipo String Y Tiene .ToLower, Hay Que Colocar Entre Comilla
    "sabado" => "Clases De Posgrado.",
    "domingo" => "Descanso.", 
    _ => "Dia No Valido"
};
Console.WriteLine(Jornada);
*/
 
/* #Ejercicio 4. Cafetería universitaria
const decimal c01 = 2500;
const decimal c02 = 3000;
const decimal c03 = 4000;
const decimal c04 = 14000;
decimal TotalPagar;
String ListaP = @"
1. Cafe (C01) - $2.500
2. Empanada (C02) - $3.000
3. Jugo (C03) - $4.000
4. Almuerzo (C04) - $14.000";
Console.WriteLine(ListaP);
Console.Write("Ingrese Codigo Del Producto: ");
string Codigo = Console.ReadLine().ToLower();
int Cantidad;
switch (Codigo)
{
    case "c01":
     Console.Write("Ingrese La Cantidad: ");
     Cantidad = int.Parse(Console.ReadLine());
     TotalPagar = c01 * Cantidad;
     Console.WriteLine(Cantidad + " x " + "Cafe = " + "$" + TotalPagar);
    break;
    case "c02":
     Console.Write("Ingrese La Cantidad: ");
     Cantidad = int.Parse(Console.ReadLine());
     TotalPagar = c02 * Cantidad;
     Console.WriteLine(Cantidad + " x " + "Empanada = " + "$" + TotalPagar);
    break;
    case "c03":
     Console.Write("Ingrese La Cantidad: ");
     Cantidad = int.Parse(Console.ReadLine());
     TotalPagar = c03 * Cantidad;
     Console.WriteLine(Cantidad + " x " + "Jugo = " + "$" + TotalPagar);
    break;
    case "c04":
     Console.Write("Ingrese La Cantidad: ");
     Cantidad = int.Parse(Console.ReadLine());
     TotalPagar = c04 * Cantidad;   
     Console.WriteLine(Cantidad + " x " + "Almuerzo = " + "$" + TotalPagar);
    break;
    default:
     Console.WriteLine("No Se Ingreso Opcion Valida.");
    break;
}
*/

/* #Ejercicio 5. Conversor de unidades con menú
const double Libras = 2.20462;
const double Millas = 0.621371;
double Kilogramos, Kilometros, Celsius, Conversion;
int op = 0;
do
{
String Menu = @"
========== Conversor Unidades ==========

1. Kilometros A Millas.
2. Kilogramos A Libras.
3. Celsius A Fahrenheit.
0. Salir.";
Console.WriteLine(Menu);
Console.Write("Opción: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
     Kilometros = LeerValor("Kilometros: ");
     Conversion = Kilometros * Millas;
     Console.WriteLine(Kilometros + "km" +  " = " + Conversion + "km");
    break;
    case 2:
     Kilogramos = LeerValor("Kilogramos: ");
     Conversion = Kilogramos * Libras;
     Console.WriteLine(Kilogramos + "kg" +" = " + Conversion + "kg");
    break;
    case 3:
     Celsius = LeerValor("Celsius: ");
     Conversion = Celsius * (9.0 / 5) + 32;
     Console.WriteLine(Celsius + "°C" + " = " + Conversion + "°F");
    break;
}
} while (op != 0);
Console.WriteLine("La Buena Manito.");
static double LeerValor(string Mensaje)
{
    double Valor;
    Console.Write(Mensaje);
    while (!double.TryParse(Console.ReadLine(), out Valor))
    {
        Console.Write("Valor No Valido. Ingrese Otro Valor: ");
    }
    return Valor;
}
*/

/* #Ejercicio 6. Desempeño académico
string NombreEstu, Pregunta;
double Nota1, Nota2, Nota3, Promedio;
do
{
Console.Write("Nombre Del Estudiante: ");
NombreEstu = Console.ReadLine().Trim();
Nota1 = LeerNota("Nota 1 (0 A 5): ");
Nota2 = LeerNota("Nota 2 (0 A 5): ");
Nota3 = LeerNota("Nota 3 (0 A 5): ");
Promedio = (Nota1 + Nota2 + Nota3) / 3;
string Desempeño = Promedio switch
{
    >= 4.6 and <= 5.0 => "Superior",
    >= 4.0 and <= 4.59 => "Alto",
    >= 3.0 and <= 3.99 => "Basico",
    < 3.0 => "Bajo"
};
Console.WriteLine(NombreEstu + " - " + "Promedio: " + Promedio + " - " + "Desempeño: " + Desempeño);
switch (Desempeño)
{
    case "Superior":
     Console.WriteLine("¡Excelente Trabajo!. Postula A Monitoría.");
    break;
    case "Alto":
     Console.WriteLine("Aprobó La Asignatura.");
    break;
    case "Basico":
     Console.WriteLine("Aprobó La Asignatura.");
    break;
    case "Bajo":
     Console.WriteLine("Debe Presentar Habilitación.");
    break;
}
Console.Write("¿Registrar Otro Estudiante? (S/N): ");
Pregunta = Console.ReadLine().ToLower().Trim();
} while (Pregunta != "n");
static double LeerNota(string Mensaje)
{
    double Nota;
    Console.Write(Mensaje);
    while (!double.TryParse(Console.ReadLine(), out Nota) || Nota < 0.0 || Nota > 5.0)
    {
        Console.Write("Nota Invalida. Ingrese Otro Valor: ");
    }
    return Nota;
}
*/

/* #Ejercicio 7 (reto). Cajero automático 
decimal Saldo = 500000, Depositar, Retirar;
int op = 0;
do
{
String Menu = @"
========== Cajero ==========
1. Consultar Saldo.
2. Depositar.
3. Retirar.
0. Salir.";
Console.WriteLine(Menu);
Console.Write("Opcion: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
     Console.WriteLine("Rafael Evelio Puerta Mejia.");
     Console.WriteLine("Su Saldo Actual Es: " + Saldo);
    break;
    case 2:
     Depositar = LeerValor("¿Cuanto Desea Depositar?: ");
     Saldo = Saldo + Depositar; 
     Console.WriteLine("Deposito Exitoso. Saldo Actual: " + Saldo);
    break;
    case 3:
     Retirar = LeerValor("Valor A Retirar (Multiplos De 10.000): ");
     if (Retirar > Saldo)
        {
            Console.WriteLine("Saldo Insuficiente.");
        }
     else
        {
            if (Retirar % 10000 == 0)
            {
                Saldo = Saldo - Retirar;
                Console.WriteLine("Retiro Exitoso.");
                Console.WriteLine("El Saldo Actual Es: " + Saldo);
            }
            else
            {
                Console.WriteLine("El Cajero Solo Entrega Multiplos De 10,000.");
            }
        }
    break;
    case 0:
     Console.WriteLine("Crack.");
    break;
    default:
     Console.WriteLine("No Se Ingreso Opcion Valida.");
    break;
}
} while (op != 0);
Console.WriteLine("Buen Dia.");
static decimal LeerValor(string Mensaje)
{
    decimal Valor;
    Console.Write(Mensaje);
    while (!decimal.TryParse(Console.ReadLine(), out Valor) || Valor <= 0)
    {
        Console.Write("Valor Invalido.");
        Console.Write("Ingrese Otro Valor: ");
    }
    return Valor;
}
*/
