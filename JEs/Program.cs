
using System.Formats.Asn1;

Console.WriteLine("Du går på en väg vill du svänga höger eller vänster? ");
Console.WriteLine("höger / vänster");
string fråga1;
string fråga2;

fråga1 = Console.ReadLine();
if (fråga1.ToLower() == "höger")
{
    Console.WriteLine("Du gick in i en skog där du möter en gubbe. han frågar om du vill gå med honom!!");
    Console.WriteLine("går du med gubben eller springer du iväg");
    Console.WriteLine("gå med / springa");

    fråga1 = Console.ReadLine();    
     if (fråga1.ToLower() == "gå med")
     {
       Console.WriteLine("gubben dödar dig");
    }
    
   if (fråga1.ToLower() == "springa")
   {
     Console.WriteLine("Du sprang hem och gubben vet vart du bor nu");
   } 
    }

  if (fråga1.ToLower() == "vänster")
{
    Console.WriteLine("du kommer till en å med en bro. vill du simma under bron eller gå över??");
    Console.WriteLine("gå över / simma");

    fråga2 = Console.ReadLine();
    if (fråga2.ToLower() == "gå över")
    {
       Console.WriteLine("bron går sönder och du ramlar ned på en sten");
    }
    
  
    if (fråga2.ToLower() == "simma")
   {
     Console.WriteLine("det kommer en haj och äter upp dig");
   } 
    }

Console.ReadLine();


