// Ejercicio_1
/* int Numero;
Console.Write("Ingrese Su Numero: ");
Numero = int.Parse(Console.ReadLine());
if (Numero > 0)
{
    Console.WriteLine("Su Numero Es Positivo");
}
*/

// Ejercicio_2
/* int Edad;
Console.Write("Ingrese Su Edad: ");
Edad = int.Parse(Console.ReadLine());
if (Edad >= 18)
{
    Console.WriteLine("Usted Puede Votar");
}
*/

// Ejercicio_3
/* double descuento = 0.1;

double valor_compra, total_pagar, descuento_1;

Console.Write("Ingrese el valor de su compra: ");

valor_compra = double.Parse(Console.ReadLine());

if (valor_compra > 200000)
{
    descuento_1 = valor_compra * descuento; 
    total_pagar = valor_compra - descuento_1;
    Console.WriteLine("El valor a pagar es: " + total_pagar);
}

if (valor_compra <= 200000)
{
    Console.WriteLine("El valor a pagar es: " + valor_compra );
}

*/

// Ejercicio_4
/* int numero;

Console.Write("Ingrese el numero: ");

numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("El numero es par");
} */

// Ejercicio_5
/* float Temperatura;
Console.Write("Ingrese La Temperatura Del Paciente: ");
Temperatura = float.Parse(Console.ReadLine());
if (Temperatura >= 38.0)
{
    Console.WriteLine("Alerta: posible fiebre");
}
*/

// Ejercicio_6
/* float Nota;
Console.Write("Ingrese Su Nota: ");
Nota = float.Parse(Console.ReadLine());
if (Nota >= 3.0f)
{
    Console.WriteLine("¡Aprobo!");
}
else
{
    Console.WriteLine("Reprobo");
} 
*/

// Ejercicio_7
/*int Numero;
Console.Write("Ingrese Un Numero: ");
Numero = int.Parse(Console.ReadLine());
if (Numero % 2 == 0)
{
    Console.WriteLine("El Numero Es Par");
}
else
{
    Console.WriteLine("El Numero Es Impar");
}
*/

// Ejercicio_8
/* int Num1, Num2;
Console.Write("Ingrese El Primer Numero: ");
Num1 =  int.Parse(Console.ReadLine());
Console.Write("Ingrese El Segundo Numero: ");
Num2 = int.Parse(Console.ReadLine());
if (Num1 > Num2)
{
    Console.Write("El Mayor Es: " + Num1);
}
else
{
    Console.Write("El Mayor Es: " + Num2);
} 
*/

// Ejercicios_9
/*double Salario, HT, VH;
Console.Write("Ingrese El Valor De La Hora: ");
VH = double.Parse(Console.ReadLine());
Console.Write("Ingrese Las Horas Trabajas: ");
HT = double.Parse(Console.ReadLine());
if (HT <= 40)
{
    Salario = VH * HT;
    Console.WriteLine("El Salario Minimo Es: " + Salario);
}
else
{
    Salario = (40 * VH) + ((HT - 40) * VH * 1.5);
    Console.WriteLine("El Salario Es: " +  Salario);
}
*/

// Ejercicio_10
/* string Contraseña = "Amigo2026", C;
Console.Write("Ingrese La Contraseña: ");
C = (Console.ReadLine());
if (C == Contraseña)
{
    Console.WriteLine("Acceso Concedido");
}
else
{
    Console.WriteLine("Acceso Denegado");
} 
*/

// Ejercicio_10
/* int Numero;
Console.Write("Ingrese El Numero A Comprobar: ");
Numero = int.Parse(Console.ReadLine());
if (Numero >= 1)
{
    Console.WriteLine("El Numero Es Positivo");
}
else if (Numero == 0)
{
    Console.WriteLine("El Numero Equivale A Cero");
}
else
{
    Console.WriteLine("El Numero Es Negativo");
}  
*/

// Ejercicio_11
/* double Nota;
Console.Write("Ingrese Su Nota: ");
Nota = double.Parse(Console.ReadLine());
if (Nota <= 2.9)
{
    Console.WriteLine("Insuficiente");
}
else if (Nota >= 3.0 && Nota <= 3.9)
{
    Console.WriteLine("Aceptable");
}
else if (Nota >= 4.0 && Nota <= 4.4)
{
    Console.WriteLine("Sobresaliente");
}
else if (Nota >= 4.5 && Nota <= 5.0)
{
    Console.WriteLine("Excelente");
} 
*/

// Ejercicio _12
/* int N1, N2, N3;
Console.Write("Ingrese El Primer Numero: ");
N1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese El Segundo Numero: ");
N2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese El Tercer Numero: ");
N3 = int.Parse(Console.ReadLine());
if (N1 > N2 && N1 > N3)
{
    Console.WriteLine("El Mayor Numero Es: " + N1);
}
else if (N3 > N2 && N3 > N1)
{
    Console.WriteLine("El Mayor Numero Es " + N3);
}
else
{
    Console.WriteLine("El Mayor Numero Es: " + N2);
}
*/

// Ejercicio_13
/* int Lado1, Lado2, Lado3;
Console.Write("El Lado 1: ");
Lado1 = int.Parse(Console.ReadLine());
Console.Write("El Lado 2: ");
Lado2 = int.Parse(Console.ReadLine());
Console.Write("El Lado 3: ");
Lado3 = int.Parse(Console.ReadLine());
if (Lado1 == Lado2 && Lado2 == Lado3 && Lado3 == Lado1)
{
    Console.WriteLine("El Trinagulo Es Equilatero");
}
else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado3 == Lado1)
{
    Console.WriteLine("El Triangulo Es Isoceles");
}
else if (Lado1 != Lado2 && Lado2 != Lado3 && Lado3 != Lado1)
{
    Console.WriteLine("El Triangulo Es Escaleno");
}
*/

// Ejercicio_14
/* int Lado1, Lado2, Lado3;
Console.Write("El Lado 1: ");
Lado1 = int.Parse(Console.ReadLine());
Console.Write("El Lado 2: ");
Lado2 = int.Parse(Console.ReadLine());
Console.Write("El Lado 3: ");
Lado3 = int.Parse(Console.ReadLine());
if (Lado1 == Lado2 && Lado2 == Lado3 && Lado3 == Lado1)
{
    Console.WriteLine("El Trinagulo Es Equilatero");
}
else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado3 == Lado1)
{
    Console.WriteLine("El Triangulo Es Isoceles");
}
else if (Lado1 != Lado2 && Lado2 != Lado3 && Lado3 != Lado1)
{
    Console.WriteLine("El Triangulo Es Escaleno");
}
*/

// Ejercicio_15
/* double HorasP, Tarifa, Respuesta;
Console.WriteLine("1. Moto.");
Console.WriteLine("2. Carro.");
Console.WriteLine("3. Bus.");
Console.Write("¿Que Tipo De Vehiculo Es? (Elija Solo El Numero Correspondiente): ");
Respuesta = double.Parse(Console.ReadLine());
Console.Write("Horas De Permanencia: ");
HorasP = double.Parse(Console.ReadLine());
if (Respuesta == 1)
{
    if (HorasP <= 5)
    {
        Tarifa = HorasP * 1500;
        Console.WriteLine("La Tarifa A Pagar Es: " + Tarifa);
    }
    else if (HorasP > 5)
    {
        Tarifa = 8000;
        Console.WriteLine("El Total A Pagar Es: "+ Tarifa);
    }
}
else if (Respuesta == 2)
{
    if (HorasP <= 5)
    {
        Tarifa = HorasP * 3000;
        Console.WriteLine("La Tarifa A Pagar Es: " + Tarifa);
    }
    else if (HorasP > 5)
    {
        Tarifa = 15000;
        Console.WriteLine("La Tarifa A Pagar Es: " + Tarifa);
    }
}
else if (Respuesta == 3)
{
    if (HorasP <= 5)
    {
        Tarifa = HorasP * 6000;
        Console.WriteLine("La Tarifa A Pagar Es:" + Tarifa);
    }
    else if (HorasP > 5)
    {
        Tarifa = 30000;
        Console.WriteLine("La Tarifa A Pagar: " + Tarifa);
    }
}
else
{
    Console.WriteLine("Vehiculo Invalido");
    return;
}
*/

// Ejercicio_16
/* int Año;
Console.Write("Ingrese El Año A Determinar: ");
Año = int.Parse(Console.ReadLine());
if (Año % 4 == 0)
{
    if (Año % 100 == 0)
    {
    
     if (Año % 400 == 0)
        {
            Console.WriteLine("El Año Es Bisiesto");
        }
        else
        {
            Console.WriteLine("El Año No Es Bisiesto");
        }
    }
    else
    {
        Console.WriteLine("El Año Es Bisiesto");
    }
}
else
{
    Console.WriteLine("El Año No Es Bisiesto");
} 
*/

// Ejercicio_17
/* decimal Monto, Saldo, NuevoS;
Console.Write("Ingrese El Saldo De Su Cuenta: ");
Saldo = decimal.Parse(Console.ReadLine());
Console.Write("Ingrese El Monto A Retirar: ");
Monto = decimal.Parse(Console.ReadLine());
if (Monto > Saldo)
{
    Console.WriteLine("Fondo Insuficiente");
}
else
{
    if (Monto % 10000 == 0)
    {
        NuevoS = Saldo - Monto;
        Console.Write("El Nuevo Saldo Es: " + NuevoS);
    }
    else
    {
        Console.Write("El Cajero Solo Entrega Billetes De 10.000");
    }
}
*/

// Ejercicio_18
/* double a, b, c, Discriminante, x1, x2;
Console.Write("Ingrese El Valor De a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor De b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor De c: ");
c = double.Parse(Console.ReadLine());
if (a == 0)
{
    Console.WriteLine("No Es Una Ecuacion Cuadratica");
}
else
{
    Discriminante = Math.Pow(b , 2) - (4 * a * c);
    if (Discriminante > 0)
    {
    x1 = (-b + Math.Sqrt(Discriminante)) / (2 * a);
    x2 = (-b - Math.Sqrt(Discriminante)) / (2 * a);
    Console.WriteLine("Hay Dos Raices Reales Distintas");
    Console.WriteLine("La x1 Vale: " + x1);
    Console.WriteLine("La x2 Vale: " + x2);
    }
    else if (Discriminante == 0)
    {
        x1 = -b / (2 * a);
        Console.WriteLine("Es Una Raiz Doble Y Su Resultado Es: " + x1);
    }
    else
    {
        Console.WriteLine("Tiene Dos Raices Complejas");
    }

}
*/

// Ejercicio_19
/* int Estrato;
double ValorBase, Consumo, Total;
Console.Write("Ingrese Su Estrato: ");
Estrato = int.Parse(Console.ReadLine());
Console.Write("Ingrese El Consumo De KwH: ");
Consumo = double.Parse(Console.ReadLine());
ValorBase = Consumo * 800;
if (Estrato == 1 || Estrato == 2)
{
    Total = ValorBase * 0.5;
    Console.WriteLine("El Total A Pagar Es: " + Total);
}
else if (Estrato == 3)
{
    Total = ValorBase * 0.85;
    Console.WriteLine("El Total A Pagar Es: " + Total);
}
else if (Estrato == 4)
{
    Total = ValorBase * 1.00;
    Console.WriteLine("El Total A Pagar Es: " + Total);
}
else if (Estrato == 5 || Estrato == 6)
{
    Total = ValorBase * 1.20;
    Console.WriteLine("El Total A Pagar Es: " + Total);
}
else
{
    Console.WriteLine("Estrato Invalido");
    return;
}
*/

// Ejercicio_20
/* string Usuario  = "rpuerta", Contraseña = "Amigo2026", N, C;
Console.Write("Ingrese Su Usuario: ");
N = (Console.ReadLine());
if (N != Usuario)
{
    Console.WriteLine("Usuario No Registrado");
}
else
{
    Console.Write("Ingrese La Contraseña: ");
    C = (Console.ReadLine());
    if (C == Contraseña)
    {
        Console.WriteLine("Bienvenido, Rafael Evelio Puerta Mejia");
    }
    else
    {
        Console.WriteLine("Contraseña Incorrecta");
    }
}
*/

// Ejercicio_21
/* double Nota;
Console.Write("Ingrese Nota: ");
Nota = double.Parse(Console.ReadLine());
if (Nota >= 0.0 && Nota <= 5.0)
{
    Console.WriteLine("Nota Valida");
}
else
{
    Console.WriteLine("Nota Fuera De Rango");
}
*/

// Ejercicio_22
/* int Dia;
Console.Write("Ingrese EL Dia A Comprobar: ");
Dia = int.Parse(Console.ReadLine());
if (Dia >= 1 && Dia <= 5)
{
    Console.WriteLine("Dia Habil");
}
else if (Dia == 7 || Dia == 6)
{
    Console.WriteLine("Fin De Semana");
}
else
{
    Console.WriteLine("Dia Invalido");
}
*/

// Ejercicio_24
/* int Año;
Console.Write("Ingrese El Año A Determinar: ");
Año = int.Parse(Console.ReadLine());
if ((Año % 4 == 0 && Año % 100 != 0) || Año % 400 == 0)
{
    Console.WriteLine("El Año Es Bisiesto");
}
else
{
    Console.WriteLine("El Año No Es Bisiesto");
} 
*/

// Ejercicio_25
/* /* int Edad;
Boolean Boleta, Lista;
Console.Write("Ingrese Su Edad: ");
Edad = int.Parse(Console.ReadLine());
Console.Write("¿Tiene Boleta? (true/false): ");
Boleta = Boolean.Parse(Console.ReadLine());
Console.Write("¿Esta En La Lista? (true/false): ");
Lista = Boolean.Parse(Console.ReadLine());
if (Edad >= 18 && (Boleta == true || Lista == true))
{
    Console.WriteLine("Puede Ingresar");
}
else
{
    Console.WriteLine("No Puede Ingresar");
}
*/
