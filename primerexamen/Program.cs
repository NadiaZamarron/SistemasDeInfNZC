
// Control para la inscripción a un evento académico

void Menu(){
Console.Clear();
System.Console.WriteLine("Tipo de usuario: [1] Alumno $100, [2] Trabajador $200, [3] Docente $500");
System.Console.WriteLine("Tipo de paquete: [A] Solo conferencias $600, [B] Con eventos sociales $800, [C] Con kit de acceso $900");

}

char us, paq;
string alumno, trabajador, docente, usuario, paquete;
float subtotal = 0, cantidad, descuento, total;

if (args.Length<3) 
{
    Menu();
    return 1;
}

us = char.Parse(args[0].ToUpper());
if (us == '1')
{
    usuario = "Alumno";
    subtotal+=100;
}else if (us == '2' )
{
    usuario = "Trabajador";
    subtotal+=200;
}else
{
    usuario = "Docente";
    subtotal +=500;
}

//Elegir paquete
paq = char.Parse(args[1].ToUpper());
if (paq == 'A')
{
    paquete = " Solo conferencias";
    subtotal+=600;
}else if (paq == 'B' )
{
    paquete = "Con eventos sociales";
    subtotal+=800;
}else
{
    paquete = "Con kit de acceso";
    subtotal+=900;
}

//Cantidad
cantidad = float.Parse(args[2]);
subtotal = subtotal * cantidad;

//Descuento
if (subtotal > 5000)
{
    descuento = 0.20f;
    usuario = "Alumno";
}else if (subtotal > 5000 && usuario == "Trabajador" )
{
    descuento = 0.10f;
    
}else
{
    descuento = 0.05f;
    usuario = "Docente";
}
total = subtotal - (subtotal * descuento);

Console.WriteLine($"Usuario: {usuario}");
Console.WriteLine($"Paquete: {paquete}");
Console.WriteLine($"Total: {total} $Subtotal: {subtotal:c}, descuento: {subtotal*descuento:c} ({descuento:p2}), Total con descuento: {total:c}");
return 0;
