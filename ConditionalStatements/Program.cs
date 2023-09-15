// See https://aka.ms/new-console-template for more information
//#10

Console.WriteLine("#10");
Console.WriteLine("What is the temperature?");

int n = Convert.ToInt32(Console.ReadLine());

if (n < 0) {
    Console.WriteLine("Freezing weather"); }
if (n >= 0 && n < 10) {
    Console.WriteLine("Very cold weather"); }
if (n >= 10 && n < 20) {
    Console.WriteLine("Cold weather"); }
if (n >= 20 && n < 30) {
    Console.WriteLine("Normal in Temp "); }
if (n >= 30 && n < 40) {
    Console.WriteLine("Its Hot "); }
if (n >= 40) {
    Console.WriteLine("Its Very Hot"); }
