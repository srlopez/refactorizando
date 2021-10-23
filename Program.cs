/*
PROGRAMACION ESTRUCTURADA EN PPROCEDIMIENTOS
con las siguientes instrucciones exclusivamente IF, GOTO y LABEL

Calcula la media del array, los participanntes, 

Restricciones:
    - todo variables globales
    - ninguna función
    - no usar llaves {} para bloques de instruciones
    - if sin else.
Permitido:
    - metodos de coleciones y arrays
*/

using System;
// Diseño de los datos
var ne = new[] { "Luis", "Marta", "Marcos", "Aroa", "Nerea", "Kike", "Juan" };
var so = new[] { 'H', 'M', 'H', 'M', 'M', 'H', 'H' };
var ns = new[] { 7.5M, 4, 6, 5, 4, 6.5M, 7.5M };
// DECLARACION 
decimal x;
decimal s;
decimal m;
int ph;
int pm;
int ah;
int am;
decimal sh;
decimal sm;

//  EMPEZAMOS
Console.WriteLine("Empiezo");
Inicializar();
//  CICLO
var i = 0; 
var n = ns.Length;
sumar:
    x = ns[i];                  //<- REF optimización
    s = s + x;
    if (x < 5) goto suspendido; //<- REF numero mágico!!! Refactorizar
    ProcesarAprovados();
    goto sigue;
suspendido:
    ProcesarSuspendidos();
sigue:
    i = i + 1;
    Console.WriteLine("en ciclo");
    if (i < n) goto sumar;
//  FIN CICLO
Console.WriteLine("fin ciclo");
Finalizar();
Console.WriteLine("Fin");


// PROCEDURE DIVISION
void Inicializar(){
    s = 0M;
    m = 0M;
    ph = 0;
    pm = 0;
    ah = 0;
    am = 0;
    sh = 0M;
    sm = 0M;
}
void Finalizar(){
    //  MEDIA
    m = s / n;
    Console.WriteLine($"participantes {n} H={ah + ph} M={am + pm}");
    // Refactorizar expresion
    Console.WriteLine($"La media es {m:0.00} H={sh / (ah + ph):00.00} M={sm / (am + pm):00.00}");
    // SUSPENSOS 
    Console.WriteLine($"Suspenso  H={ph} M={pm}");
    // APROVADOS 
    Console.WriteLine($"Aprobados H={ah} M={am}");
}
void ProcesarAprovados()
{
    if (so[i] == 'M') goto AM;
    ProcesarHA();
    return;
AM:
    ProcesarMA();
}
void ProcesarSuspendidos()
{
    if (so[i] == 'M') goto PM;
    ProcesarPH();
    return;
PM:
    ProcesarPM();
}
void ProcesarHA()
{
    sh = sh + x;
    ah = ah + 1;
}
void ProcesarMA()
{
    sm = sm + x;
    am = am + 1;
}
void ProcesarPH()
{
    sh = sh + x;
    ph = ph + 1;
}
void ProcesarPM()
{
    sm = sm + x;
    pm = pm + 1;
}
