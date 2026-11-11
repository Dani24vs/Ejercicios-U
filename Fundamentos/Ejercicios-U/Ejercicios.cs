//Ejercicio 1
/*
string Nombre;
int Edad=0;
Console.Write("Dime Tu Nombre: ");
Nombre = Console.ReadLine();
Console.Write("Dime Tu Edad: ");
Edad = int.Parse(Console.ReadLine());
Console.WriteLine("Hola " + Nombre + " Con " + Edad + " Años");
*/

//Ejercicio 2
/*
int a=0, b=0, suma=0;
Console.Write("Ingrese El Primer Numero: ");
a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Ingrese El Segundo Numero: ");
b = int.Parse(Console.ReadLine() ?? "");
suma=a+b;
Console.WriteLine("La Suma De Los Numeros Es: " + suma);
*/

//Ejercicio 3
/*
double Valor1=0, Operacion=0;
Console.Write("Ingrese El Numero A Operar El Porcentaje (Solo El 5%): ");
Valor1 = double.Parse(Console.ReadLine());
Operacion = Valor1 * 0.05;
Console.WriteLine("El 5% De Tu Numero Es: " + Operacion);
*/

//Ejercicio 4
/*
float Base=0, Altura=0, Area=0;
Console.Write("Ingrese La Base: ");
Base =  float.Parse(Console.ReadLine());
Console.Write("Ingrese La Altura: ");
Altura = float.Parse(Console.ReadLine());
Area = (Base * Altura) / 2;
Console.WriteLine("El Area De Este Triangulo Es: " + Area);
*/

//Ejercicio 5
/*
float Base=0, Altura=0, Area=0;
Console.Write("Ingrese La Base: ");
Base =  float.Parse(Console.ReadLine());
Console.Write("Ingrese La Altura: ");
Altura = float.Parse(Console.ReadLine());
Area = Base * Altura;
Console.WriteLine("El Area De Este Rectangulo Es: " + Area);
*/

//Ejercicio 6
/*
float Lado=0, Area=0;
Console.Write("Ingrese El Lado A Calcular: ");
Lado =  float.Parse(Console.ReadLine());
Area = Lado * Lado;
Console.WriteLine("El Area De Este Cuadrado Es: " + Area);
*/

//Ejercicio 7
/*
double Circulo=0, Area=0;
Console.Write("Ingrese El Radio Del Circulo: ");
Circulo = double.Parse(Console.ReadLine());
Area = Math.PI * (Circulo * Circulo);
Console.WriteLine("El Area De Este Circulo Es: " + Area);
*/

//Ejercicio 8
/*
float N1=0, N2=0, N3=0, Promedio=0;
Console.Write("Ingrese La Nota 1: ");
N1 = float.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota 2: ");
N2 = float.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota 3: ");
N3 = float.Parse(Console.ReadLine());
Promedio = (N1 + N2 + N3) / 3;
Console.WriteLine("El Promedio Sus Notas Es: " + Promedio);
*/

//Ejercicio 9
/*
float P1, P2, P3, Promedio;
Console.Write("Edad De La Persona 1: ");
P1 = float.Parse(Console.ReadLine());
Console.Write("Edad De La Persona 2: ");
P2 = float.Parse(Console.ReadLine());
Console.Write("Edad De La Persona 3: ");
P3 = float.Parse(Console.ReadLine());
Promedio = (P1 + P2 + P3) / 3;
Console.WriteLine("El Promedio De Las Edades Es: " + Promedio);
*/

//Ejercicio 10
/*
float Peso, Tasa, Conversion;
Console.Write("Ingrese El Valor De Pesos: ");
Peso = float.Parse(Console.ReadLine());
Console.Write("Ingrese Tasa De Cambio: ");
Tasa = float.Parse(Console.ReadLine());
Conversion = Peso / Tasa;
Console.WriteLine("Tu Conversion Es: " + Conversion);
*/

//Ejercicio 11
/*
int Edad=0, C=0;
Console.Write("Ingrese La Edad De La Persona: ");
Edad = int.Parse(Console.ReadLine());
C = (220 - Edad) / 10;
Console.WriteLine("Esta Persona Tiene " + C + " Pulsaciones Por Cada 11 Segundos");
*/

//Ejercicio 12
/*
decimal SalarioAnterior, SalarioActual;
Console.Write("Ingrese el salario anterior del obrero: ");
SalarioAnterior = decimal.Parse(Console.ReadLine());
Console.Write("Ingrese el salario actual del obrero: ");
SalarioActual = decimal.Parse(Console.ReadLine());

if (SalarioActual >= SalarioAnterior * 1.25)
    Console.WriteLine("Sí obtuvo un incremento de al menos 25%.");
else
    Console.WriteLine("No obtuvo un incremento de al menos 25%.");

*/

//Ejercicio 13
/*
double Valor_Compra, Ganancia;
Console.Write("Ingrese El Valor Del Producto: ");
Valor_Compra = double.Parse(Console.ReadLine());
Ganancia = (Valor_Compra * 0.3) + Valor_Compra;
Console.WriteLine("Debes Vender Esto: " + Ganancia + " Para Tener Una Ganancia Del 30%");
*/

//Ejercicio 14
/*
float D1, D2, D3, D4, D5, D6, D7, Promedio;
Console.Write("Ingrese El Tiempo Del Dia 1: ");
D1 = float.Parse(Console.ReadLine());
Console.Write("Ingrese El Tiempo Del Dia 2: ");
D2 = float.Parse(Console.ReadLine());
Console.Write("Ingrese El Tiempo De Dia 3: ");
D3 = float.Parse(Console.ReadLine());
Console.Write("Ingrse  El Tiempo Del Dia 4: ");
D4 = float.Parse(Console.ReadLine());
Console.Write("Ingrese El Timepo Del Dia 5: ");
D5 = float.Parse(Console.ReadLine());
Console.Write("Ingrese El Tiempo Del Dia 6: ");
D6 = float.Parse(Console.ReadLine());
Console.Write("Ingrese El Tiempo Del Dia 7: ");
D7 = float.Parse(Console.ReadLine());
Promedio = (D1 + D2 + D3 + D4 + D5 + D6 + D7) / 7;
Console.WriteLine("El Tiempo Promedio Del Recorrido Durante La Semana Es: " + Promedio);
*/

//Ejercicio 15
/*
string Nombre;
float VH=0, HT=0, SM=0;
Console.Write("Ingrese El Nombre Del Empleado: ");
Nombre = Console.ReadLine();
Console.Write("Ingrese El Valor De La Hora: ");
VH = float.Parse(Console.ReadLine());
Console.Write("Ingrese Las Horas Trabajadas: ");
HT = float.Parse(Console.ReadLine());
SM = VH * HT;
Console.WriteLine("El Sueldo Mensual Del Empleado " + Nombre + " Es: " + SM);
*/

//Ejercicio 16
/*
float Prestamo, Total_Pagado, Interes, Porcentaje;
Console.Write("Ingrese El Valor Del Prestamo: ");
Prestamo = float.Parse(Console.ReadLine());
Console.Write("Ingrese Total Pagado: ");
Total_Pagado = float.Parse(Console.ReadLine());
Interes = Total_Pagado - Prestamo;
Porcentaje = (Interes * 100) / Prestamo;
Console.WriteLine("El Interes Pagado Es: " + Interes);
Console.WriteLine("El Porcentaje De Interes Pagado Es: " + Porcentaje + "%");
*/

//Ejercicio 17
/*
double Patrimonio, Renta, P1, R1, CV, CF, Total_A_Pagar;
Console.Write("Ingrese El Valor Del Patrimonio: ");
Patrimonio =double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor De Renta: ");
Renta = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor De Los Cargos Fijos: ");
CF = double.Parse(Console.ReadLine());
P1 = Patrimonio * 0.10;
R1 = Renta * 0.15;
CV = P1 + R1;
Total_A_Pagar = CV + CF;
Console.WriteLine("El Total A Pagar De La Matricula Es: " + Total_A_Pagar);
*/

//Ejercicio 18
/*
double Presion, Volumen, Temperatura, Masa;
Console.Write("Ingrese El Valor De La Presion: ");
Presion = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor Del Volumen: ");
Volumen = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor De La Temperatura: ");
Temperatura = double.Parse(Console.ReadLine());
Masa = (Presion  * Volumen) / (1.37 * (Temperatura + 460));
Console.WriteLine("El Valor De La Masa Es: " + Masa);
*/

//Ejercicio 19
/*
double Pediatria, Traumatologia, Ginecologia, Presupuesto_Anual;
Console.Write("Ingrese El Valor Del Presupuesto Anual Del Hospital: ");
Presupuesto_Anual = double.Parse(Console.ReadLine());
Ginecologia = Presupuesto_Anual * 0.40;
Pediatria = Presupuesto_Anual * 0.30;
Traumatologia = Presupuesto_Anual * 0.30;
Console.WriteLine("La Cantidad De Dinero Que Recibira El Area De Ginecologia Sera: " + Ginecologia);
Console.WriteLine("La Cantidad De Dinero Que Recibira El Area De Pediatria Sera: " + Pediatria);
Console.WriteLine("La Cantidad De Dinero Que Recibira El Area De Traumatologia Sera: " + Traumatologia);
*/

//Ejercicio 20
/*
float N1, N2, N3, Examen, PromedioNota, T1, T2, T3, PT, PE;
Console.Write("¿Cuanto Saco En La Primera Tarea?: ");
N1 = float.Parse(Console.ReadLine());
Console.Write("¿Cuanto Saco En La Segunda Tarea?: ");
N2 = float.Parse(Console.ReadLine());
Console.Write("¿Cuanto Saco En La Tercera Tarea?: ");
N3 = float.Parse(Console.ReadLine());
Console.Write("¿Cuanto Saco En El Examen?: ");
Examen = float.Parse(Console.ReadLine());
T1 = N1 * (0.10f / 3);
T2 = N2 * (0.10f / 3);
T3 = N3 * (0.10f / 3);
PT = T1 + T2 + T3;
PE = Examen * 0.9f;
PromedioNota = PT + PE;
Console.WriteLine("Su Nota Definitiva Es: " + PromedioNota);

*/

//Ejercicio 21
/*
double Valor1, Valor2, Conversion;
Console.Write("Ingrese El Valor 1 A Dividir: ");
Valor1 =  double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor 2 A Dividir: ");
Valor2 = double.Parse(Console.ReadLine());
if (Valor2 == 0)
{
    Console.Write("Error! No Ingrese Valores En O");
    return;
}
Conversion = Valor1 / Valor2;
Console.WriteLine("El Resultado De La Division Es: " + Conversion);
*/

//Ejercicio 22
/*
double ValorHora, HorasT, Retencion, TotalSalario, C;
Console.Write("Ingrese El Valor De La Hora: ");
ValorHora = double.Parse(Console.ReadLine());
Console.Write("Ingrese Las Horas Trabajadas: ");
HorasT = double.Parse(Console.ReadLine());
C = ValorHora * HorasT;
Retencion = C * 0.05;
TotalSalario = C - Retencion;
Console.WriteLine("El Salario Neto Del Trabajador Es: "+ TotalSalario);
*/

//Ejercicio 23
/*
float Base, Altura, Area, Perimetro;
Console.Write("Ingrese La Base Del Rectangulo: ");
Base = float.Parse(Console.ReadLine());
Console.Write("Ingrese La Altura Del Rectangulo: ");
Altura =  float.Parse(Console.ReadLine());
Area = Base * Altura;
Perimetro = 2 * (Base + Altura);
Console.WriteLine("El Area De Este Rectangulo Es: " + Area);
Console.WriteLine("Su Perimetro Es: " + Perimetro);
*/

//Ejercicio 24
/*
double Lado, Cuadrado, Cubo;
Console.Write("Ingrese El Lado Del Cuadrado: ");
Lado = double.Parse(Console.ReadLine());
Cuadrado = Math.Pow(Lado, 2);
Cubo = Math.Pow(Lado, 3);
Console.WriteLine("El Cuadrado De Este Cuadrado (Suena Todo Charro JAJAJSJSJ): " + Cuadrado);
Console.WriteLine("El Cubo De Este Cuadrado: " + Cubo);
*/

//Ejercicio 25
/*
double Area, Radio, LC;
Console.Write("Dime El Radio Del Circulo: ");
Radio = double.Parse(Console.ReadLine());
Area = Math.PI * Math.Pow(Radio, 2);
LC = 2 * Math.PI * Radio;
Console.WriteLine("El Area Del Circulo Es: " + Area);
Console.WriteLine("La Longitud De La Circunferencia Es: " + LC);
*/

//Ejercicio 26
/*
double Lado1, Lado2, Lado3, Perimetro, SemiP, Area;
Console.Write("Dime El Valor Del Lado 1 Del Triangulo: ");
Lado1 = double.Parse(Console.ReadLine());
Console.Write("Dime El Valor Del Lado 2 Del Triangulo: ");
Lado2 = double.Parse(Console.ReadLine());
Console.Write("Dime El Valor Del Lado 3 Del Triangulo: ");
Lado3 = double.Parse(Console.ReadLine());
Perimetro = Lado1 + Lado2 + Lado3;
SemiP = Perimetro / 2;
Area = Math.Sqrt(SemiP * (SemiP - Lado1) * (SemiP - Lado2) * (SemiP - Lado3));
Console.WriteLine("El Perimetro De Este Triangulo Es: " + Perimetro);
Console.WriteLine("El Semiperimetro De Este Triangulo Es: " + SemiP);
Console.WriteLine("El Area De Este Triangulo Es: " + Area);
*/

//Ejercicio 27
/*
double VelocidadM_S, VelocidadK_M;
Console.Write("Ingrese La Velocidad Del Movil: ");
VelocidadM_S = double.Parse(Console.ReadLine());
VelocidadK_M = VelocidadM_S * 3.6;
Console.WriteLine("La Velocidad En Kilometros Sera: " + VelocidadK_M);
*/

//Ejercicio 28
/*
double Descuento, Compra, TotalPagar;
Console.Write("ingrese El Valor De La Compra: ");
Compra = double.Parse(Console.ReadLine());
Descuento = Compra * 0.10;
TotalPagar = Compra - Descuento;
Console.WriteLine("El Total A Pagar Con Descuento Sera: " + TotalPagar);
*/

//Ejercicio 29
/*
double V, M, TA, PV, PM, ComprobacionDeEstudiantes;
Console.Write("¿Cuantos Alumnos En Total Hay?: ");
TA =  double.Parse(Console.ReadLine());
Console.Write("¿Cuantos Alumnos Varones Hay?: ");
V = double.Parse(Console.ReadLine());
Console.Write("¿Cuantas Alumnas Mujeres Hay?: ");
M = double.Parse(Console.ReadLine());
if (TA == 0)
{
    Console.WriteLine("Error: El Total De Alumnos No Puede Ser 0.");
    return;
}
ComprobacionDeEstudiantes = V + M;
if (TA == ComprobacionDeEstudiantes)
{
    Console.WriteLine("La Cantidad De Alumnos Coincide Con El Total.");
}
else
{
    Console.WriteLine("Error: La Suma De Hombres Y Mujeres No Conicide Con El Total.");
    return;
}
PV = (V / TA) * 100;
PM = (M / TA) * 100;
Console.WriteLine("El Promedio De Alumnos Varones Es: " + PV);
Console.WriteLine("El Promedio De Alumnas Mujeres: " + PM);
*/

//Ejercicio 30
/*
double V1, V2, V3, MontoVentas, SueldoBase, ConversionSueldo;
Console.Write("Ingrese El Valor De La Primera Venta: ");
V1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor De La Segunda Venta: ");
V2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor De La Tercera Venta: ");
V3 = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Sueldo Base: ");
SueldoBase = double.Parse(Console.ReadLine());
MontoVentas = (V1 + V2 + V3) * 0.12;
ConversionSueldo = SueldoBase + MontoVentas;
Console.WriteLine("El Sueldo Neto De Este Vendedor Es: " + ConversionSueldo);
*/

//Ejercicio 31
/*
double E1, E2, E3, P1, P2, P3;
Console.Write("Ingrese El Sueldo Del Primer Empleado: ");
E1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Sueldo Del Segundo Empleado: ");
E2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Sueldo Del Tercer Empleado: ");
E3 = double.Parse(Console.ReadLine());
P1 =  E1 * 1.10;
P2 = E2 * 1.12;
P3 = E3 * 1.15;
Console.WriteLine("El Sueldo Del Primer Empleado Con 10% De Aumento Es: " + P1);
Console.WriteLine("El Sueldo Del Segundo Empleado Con 12% De Aumento Es: " + P2);
Console.WriteLine("El Sueldo Del Tercer Empleado Con 15% De Aumento Es: " + P3);
*/

//Ejercicio 32
/*
double Gigas, Megas, Kilo, Bytes;
Console.Write("Ingrese El Valor De Las Gigas De Este Disco Duro: ");
Gigas = double.Parse(Console.ReadLine());
Megas = Gigas * 1024;
Kilo = Megas * 1024;
Bytes = Kilo * 1024;
Console.WriteLine("Las Megabytes De Este Disco Duro Son: " +  Megas.ToString("N2"));
Console.WriteLine("Los Kilobytes De Este Disco Duro Son: " +  Kilo.ToString("N2"));
Console.WriteLine("Los Bytes De Este Disco Duro Son: " +  Bytes.ToString("N2"));
*/

//Ejercicio 33
/*
double CM, Conversion;
Console.Write("Ingrese El Valor De Centimetros A Convertir: ");
CM = double.Parse(Console.ReadLine());
Conversion = CM * 0.39737;
Console.WriteLine("Las Pulgadas De Este Centimetros Serian: " + Conversion);
*/

//Ejercicio 34
/*
double Libras, KG;
Console.Write("Ingrese Las Libras A Convertir: ");
Libras =  double.Parse(Console.ReadLine());
KG =  Libras / 2.2046;
Console.WriteLine("Los Kilogromos Equivalen A: " + KG);
*/

//Ejercicio 35
/*
int Meses, Años, TotalMeses;
Console.Write("Ingrese Su Edad: ");
Años = int.Parse(Console.ReadLine());
Console.Write("Ingrese Sus Meses: ");
Meses = int.Parse(Console.ReadLine());
TotalMeses  = (Años * 12) + Meses;
Console.WriteLine("El Total De Meses Segun Su Edad Son: " + TotalMeses);
*/

//Ejercicio 36
/*
double KG, Gramos, Libras, Toneladas;
Console.Write("Ingrese El Valor De Los Kilogramos: ");
KG = double.Parse(Console.ReadLine());
Gramos = KG * 1000;
Libras = KG * 2.2046;
Toneladas = KG / 1000;
Console.WriteLine("La Conversion A Gramos Equivale A: " + Gramos);
Console.WriteLine("La Conversion A Libras Equivale A: " + Libras);
Console.WriteLine("La Conversion A Toneladas Equivale A: " + Toneladas);
*/

//Ejercicio 37
/*
Aqui Toca Revisar Bien El Enunciado.
*/

//Ejercicio 38
/*
double N1, N2, N3, ExamenM, PromedioNotaM, T1, T2, T3, PTM, PEM, N4, N5, ExamenF, PromedioNotaF, T4, T5, PTF, PEF, N6, N7, N8, ExamenQ, PromedioNotaQ, T6, T7, T8, PTQ, PEQ, PromedioGeneral;
Console.WriteLine("-----MATEMATICAS-----");
Console.Write("Ingrese La Nota De La Tarea 1: ");
N1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota De La Tarea 2: ");
N2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota De La Tarea 3: ");
N3 = double.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota Del Examen: ");
ExamenM = double.Parse(Console.ReadLine());
T1 = N1 * (0.10 / 3);
T2 = N2 * (0.10 / 3);
T3 = N3 * (0.10 / 3);
PTM = T1 + T2 + T3;
PEM = ExamenM * 0.9;
PromedioNotaM = PTM + PEM;
Console.WriteLine("El Promedio De La Materia De Matematicas Es: " + PromedioNotaM);
// AAAAAH, Que Belleza De Problemita, Sipote Cosa, AJA MOTO QUE
Console.WriteLine("-----FISICA----");
Console.Write("Ingrese La Nota De La Tarea 1: ");
N4 = double.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota De La Tarea 2: ");
N5 = double.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota Del Examen: ");
ExamenF = double.Parse(Console.ReadLine());
T4 = N4 * (0.20 / 2);
T5 = N5 * (0.20 / 2);
PTF = T4 + T5;
PEF = ExamenF * 0.8;
PromedioNotaF = PTF + PEF;
Console.WriteLine("El Promedio De La Materia De Fisica Es: " + PromedioNotaF);
// AJA MOTO QUE'
Console.WriteLine("----QUIMICA----");
Console.Write("Ingrese La Nota De La Tarea 1: ");
N6 = double.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota De La Tarea 2: ");
N7 = double.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota De La Tarea 3: ");
N8 = double.Parse(Console.ReadLine());
Console.Write("Ingrese La Nota Del Examen: ");
ExamenQ = double.Parse(Console.ReadLine());
T6 = N6 * (0.15 / 3);
T7 = N7 * (0.15 / 3);
T8 = N8 * (0.15 / 3);
PTQ = T6 + T7 + T8;
PEQ = ExamenQ * 0.85;
PromedioNotaQ = PTQ + PEQ;
PromedioGeneral = (PromedioNotaM + PromedioNotaF + PromedioNotaQ) / 3;
Console.WriteLine("El Promedio De La Materia De Quimica Es: " + PromedioNotaQ);
Console.WriteLine("El Promedio General De Todas Las Materias Es: " + PromedioGeneral);
*/

//Ejercicio 39
/*
double a, b, c , T, R, Y, w = 20457;
Console.Write("Ingrese El Valor De a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor De b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Ingrese El Valor De c: ");
c = double.Parse(Console.ReadLine());
R = (c * 2) + (b * 2) * (a * 2);
Y = w + (c * 3) + (b * 2);
T = (R * 3) /  Y * (w * 5);
Console.WriteLine("El Resultado De La Ecuacion (r3/y *w5) Es: " + T.ToString("N2"));

// Aqui Talvez Es Potencia Y No Multipicacion.
// Tambien Revisa Ese Valor De w.s
*/

//Ejercicio 40
/*
double VBoleta, BoletasV1, BoletasV2, BoletasV3, TotalR, TotalG, P1, P2, P3;
Console.Write("¿Cuanto Vale Cada Boleta?: ");
VBoleta = double.Parse(Console.ReadLine());
Console.Write("¿Cuantas Boletas Se Vendio En El Primer Partido?: ");
BoletasV1 = double.Parse(Console.ReadLine());
Console.Write("¿Cuantas Boletas Se Vendio En El Segundo Partido?: ");
BoletasV2 = double.Parse(Console.ReadLine());
Console.Write("¿Cuantas Boletas Se Vendio En El Tercer Partido?: ");
BoletasV3 = double.Parse(Console.ReadLine());
P1 = (BoletasV1 * VBoleta) * 0.2;
P2 = (BoletasV2 * VBoleta) * 0.3;
P3 = (BoletasV3 * VBoleta) * 0.4;
TotalR = (BoletasV1 * VBoleta) + (BoletasV2 * VBoleta) + (BoletasV3 * VBoleta);
TotalG = P1 + P2 + P3;
Console.WriteLine("El Total Recaudado En El Mes Es: " + TotalR);
Console.WriteLine("El Total Ganado Para El Equipo Es: " + TotalG);

// Esta Bien Pero Joa, Puede Faltar Algo. AJA MOTO QUE
*/

//Ejercicio 41
/*
double DM, Dm, Area;
Console.Write("Ingrese La Diagonal Mayor Del Rombo: ");
DM = double.Parse(Console.ReadLine());
Console.Write("Ingrese La Diagonal Menor Del Rombo: ");
Dm = double.Parse(Console.ReadLine());
Area = (DM * Dm) / 2;
Console.WriteLine("El Area De Este Rombo Es: " + Area + "cm²");
*/
