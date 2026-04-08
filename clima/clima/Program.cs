
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

float [] temp = new float [12];

float [] presipitacion = new float [12];


string [] temptipo = new string[12];

string [] prestipo = new string[12];

string[] meses  = new string [12] {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio",  "agosto", "septiembre", "octubre", "noviembre", "diciembre"};






for (int i = 0; i < 12; i++)
{



    Console.WriteLine("coloca la temperatura del mes " + meses[i]);
     string temperatura = Console.ReadLine();

    if (float.TryParse( temperatura , out temp[i]))
    {
        
    }
    else
    {
        Console.WriteLine("La temperatura tiene que ser numerica. no se admiten caracteres especiales");

        i--;

        continue;
    }



    if (temp[i] > 57 || temp[i] < -89)
    {
        Console.WriteLine("Temperatura fuera de lo normal. Intentelo de nuevo");

        i--;

        continue;
    }
    

}



    for (int i = 0; i < 12; i++)
    {

    

        Console.WriteLine("coloca la presipitacio del mes " + meses[i]);
        string  presipitacio = Console.ReadLine();



        if (float.TryParse(presipitacio, out presipitacion[i]))
        {

        }
        else
        {
            Console.WriteLine("La presipitacion tiene que ser numerica. no se admiten caracteres especiales");

            i--;

            continue;
        }






    if (presipitacion[i] > 1825 || presipitacion[i] < 0.86) 
        {
        Console.WriteLine("Presipitacion fuera de lo normal. intentelo de nuevo.");

        i--;

        continue;
           }
    


    }


    // coso de los aridos


for (int i = 0; i < 12; i++)
{
    if (temp[i]  < 10 )
    {
        temptipo[i] = "fríos/polares";
    }

    if (temp[i] >= 10 && temp[i] <= 18)
    {
        temptipo[i] = "templados";
    }

    if (temp[i] > 18)
    {
        temptipo[i] = "cálido";
    }
}




for (int i = 0; i < 12; i++)
{
    if (presipitacion[i] < 250)
    {
        prestipo[i] = "deserticos";
    }

    if (presipitacion[i] >= 250 && temp[i] <= 500)
    {
        prestipo[i] = "arido";
    }

    if (presipitacion[i] > 500 && temp[i] <= 2000)
    {
        prestipo[i] = "moderadamente lluvioso";
    }

    if (presipitacion[i] > 2000)
    {
        prestipo[i] = "excesivamente lluvioso";
    }


}


// comparacion  temperatura mayor y menor

float temperatura_mayor = -10000000;

string maximo_mes= "";

for (int i = 0; i < 12; i++)
{

    

    if (temp[i] > temperatura_mayor  )
    {
        temperatura_mayor = temp[i];    
        maximo_mes = meses[i];
    }


}

Console.WriteLine("la  temperatura mayor   es  " + temperatura_mayor +  "  del mes  " + maximo_mes );







float temperatura_menor = 10000000;

string menor_mes = "";

for (int i = 0; i < 12; i++)
{



    if (temp[i] < temperatura_menor)
    {
        temperatura_menor = temp[i];
        menor_mes = meses[i];
    }


}

Console.WriteLine("la  temperatura menor   es  " + temperatura_menor + "  del mes  " + menor_mes);





// comparacion presipitacion  menor y mayor



float presipitacion_mayor = -10000000;

string maximop_mes = "";

for (int i = 0; i < 12; i++)
{



    if (presipitacion[i] > presipitacion_mayor)
    {
        presipitacion_mayor = presipitacion [i];
        maximop_mes = meses[i];
    }


}

Console.WriteLine("la  presipitacion mayor   es  " + presipitacion_mayor + "  del mes  " + maximop_mes);







float presipitacion_menor = 10000000;

string menorp_mes = "";

for (int i = 0; i < 12; i++)
{



    if (presipitacion[i] < presipitacion_menor)
    {
        presipitacion_menor = presipitacion[i];
        menorp_mes = meses[i];
    }


}

Console.WriteLine("la  temperatura menor   es  " + presipitacion_menor + "  del mes  " + menorp_mes);




// promedio temp 
float total = default;

for (int i = 0; i < 12; i++)
{



     total = total + temp[i];

}

float promedio_temp = default;

promedio_temp = total / 12;


Console.WriteLine($"la temperatura promedio del año es {promedio_temp}");






//--------------------------------------------------------------------------------------presipitcion promedio
