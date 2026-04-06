
float [] temp = new float [12];

float [] presipitacion = new float [12];


string [] temptipo = new string[12];

string [] prestipo = new string[12];

string[] meses  = new string [12] {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio",  "agosto", "septiembre", "octubre", "noviembre", "diciembre"};






for (int i = 0; i < 12; i++)
{


    Console.WriteLine("coloca la presipitacio del mes " + meses[i]);
    temp[i] = float.Parse(Console.ReadLine());


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
        presipitacion[i] = float.Parse(Console.ReadLine());


        if (presipitacion[i] > 1825 || presipitacion[i] < 0.86) 
        {
        Console.WriteLine("Presipitacion fuera de lo normal. intentelo de nuevo.");

        i--;

        continue;
           }
    


    }




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
        prestipo[i] = "excesivamente";
    }


}





float temperatura_mayor;

for (int i = 0; i < 12; i++)
{



    if (temp[i] > temperatura_mayor  )
    {
       
    }


}

