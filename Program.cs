/*
CODIGO IMPERATIVO
CODIGO SPAGHETTI
IF, GOTO, LABEL


BASE PARA LA REFACTORIZACION DEL LENGUAJE EN PROCEDIMIENTOS
*/

using System;
// Diseño de los datos
var ne = new[] { "Luis", "Marta", "Marcos", "Aroa", "Nerea", "Kike", "Juan" };
var so = new[] { 'H', 'M', 'H', 'M', 'M', 'H', 'H' };
var ns = new[] { 7.5M, 4, 6, 5, 4, 6.5M, 7.5M };
decimal x;
var s = 0M;
var m = 0M;
var i = 0;
var ph = 0;
var pm = 0;
var ah = 0;
var am = 0;
var sh = 0M;
var sm = 0M;

//  EMPEZAMOS
Console.WriteLine("Empiezo");
var n = ns.Length;
// CICLO
sumar:
    x = ns[i];                 //<- REF optimización
    s = s + x;
    if(x<5) goto suspendido;   //<- REF numero mágico!!! Refactorizar
    if(so[i]=='M') goto AM;
    sh = sh + x;
    ah = ah + 1;
    goto sigue;
AM:
    sm = sm + x;
    am = am + 1;
    goto sigue;
suspendido: 
    if(so[i]=='M') goto PM;
    sh = sh + x;
    ph = ph + 1;
    goto sigue;
PM:
    sm = sm + x;
    pm = pm + 1;
sigue:
    i = i + 1;
    Console.WriteLine("en ciclo");
    if (i < n) goto sumar;
//  FIN CICLO
Console.WriteLine("fin ciclo");

//  RESULTADOS
//  MEDIA
m = s / n;
Console.WriteLine($"participantes {n} H={ah+ph} M={am+pm}");
// <-- REF Refactorizar expresion
Console.WriteLine($"La media es {m:0.00} H={sh/(ah+ph):00.00} M={sm/(am+pm):00.00}");
// SUSPENSOS 
Console.WriteLine($"Suspenso  H={ph} M={pm}");
// APROBADOS 
Console.WriteLine($"Aprobados H={ah} M={am}");
Console.WriteLine("Fin");