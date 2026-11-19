/* #1
int op = 0;
Console.Write("Ingrese El Numero Del La Semana (1 A 7): ");
op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
      Console.Write("Es Lunes");
    break;
    case 2:
      Console.Write("Es Martes");
    break;
    case 3:
      Console.Write("Es Miercoles");
    break;
    case 4:
      Console.Write("Es Jueves");
    break;
    case 5:
      Console.Write("Es Viernes");
    break;
    case 6:
      Console.Write("Es Sabado");
    break;
    case 7:
      Console.Write("Es Domingo");
    break;
    default:
    case 8:
      Console.Write("No Selecciono Opcion Valida");
    break;
}
*/

/* #2
int op = 0;
double N1, N2;
String Mensaje = @"
1. Suma.
2. Resta.
3. Multiplicacion.
4. Division.";
Console.WriteLine(Mensaje);
Console.Write("Ingrese La Opcion: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
      Console.Write("Numero 1: ");
      N1 = double.Parse(Console.ReadLine());
      Console.Write("Numero 2: ");
      N2 = double.Parse(Console.ReadLine());
      double Suma = N1 + N2;
      Console.WriteLine(N1 + " + " + N2 + " = " + Suma);
    break;
    case 2:
      Console.Write("Numero 1: ");
      N1 = double.Parse(Console.ReadLine());
      Console.Write("Numero 2: ");
      N2 = double.Parse(Console.ReadLine());
      double Resta = N1 - N2;
      Console.WriteLine(N1 + " - " + N2 + " = " + Resta);
    break;
    case 3:
      Console.Write("Numero 1: ");
      N1 = double.Parse(Console.ReadLine());
      Console.Write("Numero 2: ");
      N2 = double.Parse(Console.ReadLine());
      double Multiplicacion = N1 * N2;
      Console.WriteLine(N1 + " x " + N2 + " = " + Multiplicacion);
    break;
    case 4:
      Console.Write("Numero 1: ");
      N1 = double.Parse(Console.ReadLine());
      Console.Write("Numero 2: ");
      N2 = double.Parse(Console.ReadLine());
    if (N2 == 0)
    {
        Console.WriteLine("Error No Se Puede Dividir Entre 0.");
    }
    else
    {
       double Division = N1 / N2;
      Console.WriteLine(N1 + " ÷ " + N2 + " = " + Division);
    }
    break;
    default:
    case 5:
      Console.Write("No Se Elijio Ninguna Opcion.");
    break;
}
*/

/* #3
int Mes;
Console.Write("Ingrese El Numero Del Mes: ");
Mes = int.Parse(Console.ReadLine());
switch (Mes)
{
    case 1: 
     Console.WriteLine("Es Enero.");
    break;
    case 2: 
     Console.WriteLine("Es Febrero.");
    break;
    case 3: 
     Console.WriteLine("Es Marzo.");
    break;
    case 4: 
     Console.WriteLine("Es Abril.");
    break;
    case 5: 
     Console.WriteLine("Es Mayo.");
    break;
    case 6: 
     Console.WriteLine("Es Junio.");
    break;
    case 7: 
     Console.WriteLine("Es Julio.");
    break;
    case 8: 
     Console.WriteLine("Es Agosto.");
    break;
    case 9: 
     Console.WriteLine("Es Septiembre.");
    break;
    case 10: 
     Console.WriteLine("Es Octubre.");
    break;
    case 11: 
     Console.WriteLine("Es Noviembre.");
    break;
    case 12: 
     Console.WriteLine("Es Diciembre.");
    break;
    default:
    case 13: 
     Console.WriteLine("No Se Ingreso Ningun Dato.");
    break;
}
*/

/* #4
double Depositar, Total, Retirar, Restante, Saldo = 500000;
int op = 0;
String Menu = @"
1. Cosultar Saldo.
2. Retirar.
3. Depositar.
4. Salir.";
Console.WriteLine(Menu);
Console.Write("Ingrese La Opcion: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
  case 1: 
   Console.Write("Su Saldo Actual Es: " + Saldo);
  break;
  case 2: 
   Console.Write("Cuanto Desea Retirar: ");
   Retirar = double.Parse(Console.ReadLine());
  if (Retirar <= Saldo)
  {
    Restante = Saldo - Retirar;
    Console.WriteLine("El Retiro Fue Exitoso. Su Saldo Actual Es: " + Restante);
  }
  else
  {
    Console.WriteLine("No Es Posible Este Retiro");
  }
  break;
  case 3:
   Console.Write("Ingrese El Valor A Depositar: ");
   Depositar = double.Parse(Console.ReadLine());
  if (Depositar <= 0)
  {
    Console.WriteLine("Error, No Ingrese Valores Menores O Iguales A 0");
  }
  else
  {
    Total = Saldo + Depositar;
    Console.WriteLine("Deposito Exitoso. Su Saldo Actual Es: " + Total);
  }
  break;
  case 4:
   Console.WriteLine("Ten Un Buen Dia.");
  break;
  default:
   Console.WriteLine("No Se Selecciono Ninguna Opcion.");
  break;
}
*/

/* #5
int op = 0;
String Menu = @"
1. Motocicleta.
2. Automovil.
3. Autobus.";
Console.WriteLine(Menu);
Console.Write("Ingrese El Vehiculo: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
  case 1:
  Console.WriteLine("La Tarifa De Este Vehiculo Es: $2.000.");
  break;
  case 2:
  Console.WriteLine("La Tarifa De Este Vehiculo Es: $5.000");
  break;
  case 3:
  Console.WriteLine("La Tarifa De Este Vehiculo Es: $8.000");
  break;
  default:
   Console.WriteLine("Vehiculo Invalido.");
  break;
}
*/

/* #6
int Nota = 0;
Console.Write("Ingrese Su Nota: ");
Nota = int.Parse(Console.ReadLine());
switch (Nota)
{
  case 1:
   Console.WriteLine("Deficiente.");
  break;
  case 2:
   Console.WriteLine("Insuficiente.");
  break;
  case 3:
   Console.WriteLine("Aceptable.");
  break;
  case 4:
   Console.WriteLine("Sobresaliente.");
  break;
  case 5:
   Console.WriteLine("Excelente.");
  break;
  default:
   Console.WriteLine("Nota Invalida.");
  break;
}
*/

/* #7
while(true)
{
int op = 0;
double N1, N2;
String Mensaje = @"
1. Suma.
2. Resta.
3. Multiplicacion.
4. Division.
5. Salir";
Console.WriteLine(Mensaje);
Console.Write("Ingrese La Opcion: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
      Console.Write("Numero 1: ");
      N1 = double.Parse(Console.ReadLine());
      Console.Write("Numero 2: ");
      N2 = double.Parse(Console.ReadLine());
      double Suma = N1 + N2;
      Console.WriteLine(N1 + " + " + N2 + " = " + Suma);
    break;
    case 2:
      Console.Write("Numero 1: ");
      N1 = double.Parse(Console.ReadLine());
      Console.Write("Numero 2: ");
      N2 = double.Parse(Console.ReadLine());
      double Resta = N1 - N2;
      Console.WriteLine(N1 + " - " + N2 + " = " + Resta);
    break;
    case 3:
      Console.Write("Numero 1: ");
      N1 = double.Parse(Console.ReadLine());
      Console.Write("Numero 2: ");
      N2 = double.Parse(Console.ReadLine());
      double Multiplicacion = N1 * N2;
      Console.WriteLine(N1 + " x " + N2 + " = " + Multiplicacion);
    break;
    case 4:
      Console.Write("Numero 1: ");
      N1 = double.Parse(Console.ReadLine());
      Console.Write("Numero 2: ");
      N2 = double.Parse(Console.ReadLine());
    if (N2 == 0)
    {
      Console.WriteLine("Error No Se Puede Dividir Entre 0.");
    }
    else
    {
      double Division = N1 / N2;
      Console.WriteLine(N1 + " ÷ " + N2 + " = " + Division);
    }
    break;
    case 5:
     Console.WriteLine("Chao.");
    break;
    default:
      Console.Write("No Se Elijio Ninguna Opcion.");
    break;
}
if (op == 5)
  {
    break;
  }
}
*/

/* #8
while(true)
{
int op = 0;
double Total, Descuento, Precio;
String Menu = @"
1. Cliente Frecuente.
2. Cliente Afiliado.
3. Cliente Normal.
4. Salir.";
Console.WriteLine(Menu);
Console.Write("Ingrese La Opcion: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
  case 1:
   Console.Write("Ingrese El Precio: ");
   Precio = double.Parse(Console.ReadLine());
   if (Precio <= 0)
    {
      Console.WriteLine("Error. No Se Puede Ingresar Valores Menores O Iguales A 0.");
    }
    else
    {
      Descuento = Precio * 0.20;
      Total = Precio - Descuento;
      Console.WriteLine("El Total A Pagar Es: " + Total);
    }
  break;
  case 2:
   Console.Write("Ingrese El Precio: ");
   Precio = double.Parse(Console.ReadLine());
   if (Precio <= 0)
    {
      Console.WriteLine("Error. No Se Puede Ingresar Valores Menores O Iguales A 0.");
    }
    else
    {
      Descuento = Precio * 0.10;
      Total = Precio - Descuento;
      Console.WriteLine("El Total A Pagar Es: " + Total);
    }
  break;
  case 3:
   Console.Write("Ingrese El Precio: ");
   Precio = double.Parse(Console.ReadLine());
   if (Precio <= 0)
    {
      Console.WriteLine("Error. No Se Puede ingresar Valores Menores O Iguales 0.");
    }
    else
    {
      Console.WriteLine("El Total A Pagar Es: " + Precio);
    }
  break;
  case 4:
   Console.WriteLine("La Buena Manito.");
  break;
  default:
   Console.WriteLine("No Se Ingreso Opcion Valida.");
  break;
}
if (op == 4)
 {
  break;
 }
}
*/

/* #9
int Positivos = 0, Ceros = 0, Negativos = 0; 
while(true)
{
int op = 0;
double Numero;
String Menu = @"
1. Ingresar Numero.
2. Mostrar Resultado.
3. Salir.";
Console.WriteLine(Menu);
Console.Write("Ingrese La Opcion: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
  case 1:
   Console.Write("Ingrese El Numero: ");
   Numero = double.Parse(Console.ReadLine());
   if (Numero > 0)
    {
      Console.WriteLine("Es Un Numero Positivo.");
      Positivos++;
    }
    else if (Numero == 0)
    {
      Console.WriteLine("El Numero Equivale A Cero");
      Ceros++;
    }
    else
    {
      Console.WriteLine("Es Un Numero Negativo.");
      Negativos++;
    }
  break;
  case 2:
    if (Positivos == 0 && Ceros == 0 && Negativos == 0)
    {
      Console.WriteLine("No Hay Numeros Registradros.");
    }
    else
    {
      Console.WriteLine("Cantidad De Positivos: " + Positivos);
      Console.WriteLine("Cantidad De Ceros: " + Ceros);
      Console.WriteLine("Cantidad De Negativos: " + Negativos);
      int Total = Positivos + Ceros + Negativos;
      Console.WriteLine("Total De Numeros Ingresados: " + Total);
    }
  break;
  case 3:
   Console.WriteLine("Melo Manito.");
  break;
  default:
   Console.WriteLine("No Se Ingreso Opcion Valida.");
  break;
}
if (op == 3)
  {
    break;
  }
}
*/

/* #10 
int ProductosR = 0;
double TotalP = 0;
while (true)
{
int op = 0, CantidadP;
string NombreP;
double PrecioP;
String Menu = @"
1. Registrar Productos.
2. Mostrar Resultados.
3. Salir.";
Console.WriteLine(Menu);
Console.Write("Ingrese La Opcion: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
 case 1:
   Console.Write("Ingrese El Nombre Del Producto: ");
   NombreP = Console.ReadLine();
   Console.Write("Ingrese El Precio Del Producto: ");
   PrecioP = double.Parse(Console.ReadLine());
   Console.Write("Ingrese La Cantidad Del Producto: ");
   CantidadP = int.Parse(Console.ReadLine());
   if (PrecioP > 0)
    {
      if (CantidadP > 0)
      {
        ProductosR++;
        TotalP += PrecioP * CantidadP;
      }
      else
      {
       Console.WriteLine("Cantidad Invalida.");
      }
    }
    else
    {
      Console.WriteLine("Precio Invalido.");
    }
  break;
  case 2:
    Console.WriteLine("La Cantidad De Productos Resgitrados Son: " + ProductosR);
    Console.WriteLine("El Precio Total Del Inventario Es: " + TotalP);
  break;
  case 3:
   Console.WriteLine("Salvame De Este Sufrimiento.");
  break;
  default:
   Console.WriteLine("No Se Elijio Opcion Valida.");
  break;
}
if (op == 3)
{
  break;
}
}
*/
