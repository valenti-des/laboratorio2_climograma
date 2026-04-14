string continuar = "x";
while (continuar == "x")
{
    string bim = @"










                                  ████████ ███████ ███    ███ ██████  ███████ ██████   █████  ████████ ██    ██ ██████   █████  
                                     ██    ██      ████  ████ ██   ██ ██      ██   ██ ██   ██    ██    ██    ██ ██   ██ ██   ██ 
                                     ██    █████   ██ ████ ██ ██████  █████   ██████  ███████    ██    ██    ██ ██████  ███████ 
                                     ██    ██      ██  ██  ██ ██      ██      ██   ██ ██   ██    ██    ██    ██ ██   ██ ██   ██ 
                                     ██    ███████ ██      ██ ██      ███████ ██   ██ ██   ██    ██     ██████  ██   ██ ██   ██ 
                                                                                              ";
    string texto = @"                                                                                   









                                                          ███████ ██████  ██████   ██████  ██████      
                                                          ██      ██   ██ ██   ██ ██    ██ ██   ██     
                                                          █████   ██████  ██████  ██    ██ ██████      
                                                          ██      ██   ██ ██   ██ ██    ██ ██   ██     
                                                          ███████ ██   ██ ██   ██  ██████  ██   ██     
                                            La temperatura tiene que ser numerica. no se admiten caracteres especiales 

                                                                  
                                                                        ";
    string texto2 = @"
        
        
        
        
        
        
                                                
                                                
     

                                                          ███████ ██████  ██████   ██████  ██████      
                                                          ██      ██   ██ ██   ██ ██    ██ ██   ██     
                                                          █████   ██████  ██████  ██    ██ ██████      
                                                          ██      ██   ██ ██   ██ ██    ██ ██   ██     
                                                          ███████ ██   ██ ██   ██  ██████  ██   ██     
                                                Temperatura fuera de lo normal. Presione ENTER para reintentar.";
    //----------------------ASCII temperatura
    string textop = @"                         
        
        
        
        
        
        
        
        
        
        
               --------------------------------Proceso finalizado. Presione Enter para ingresar Precipitacion---------------------------------";
    string textop2 = @"
        
        
        



                                               ██████  ██████  ███████  ██████ ██ ██████  ██ ████████  █████   ██████ ██  ██████  ███    ██ 
                                               ██   ██ ██   ██ ██      ██      ██ ██   ██ ██    ██    ██   ██ ██      ██ ██    ██ ████   ██ 
                                               ██████  ██████  █████   ██      ██ ██████  ██    ██    ███████ ██      ██ ██    ██ ██ ██  ██ 
                                               ██      ██   ██ ██      ██      ██ ██      ██    ██    ██   ██ ██      ██ ██    ██ ██  ██ ██ 
                                               ██      ██   ██ ███████  ██████ ██ ██      ██    ██    ██   ██  ██████ ██  ██████  ██   ████ 
                                                                                             
                                                                                             
                                                                                             
                                                                                             ";
    string textop3 = @"
            
        
        
        
        
        
        
                                                
                                                
     

                                                          ███████ ██████  ██████   ██████  ██████      
                                                          ██      ██   ██ ██   ██ ██    ██ ██   ██     
                                                          █████   ██████  ██████  ██    ██ ██████      
                                                          ██      ██   ██ ██   ██ ██    ██ ██   ██     
                                                          ███████ ██   ██ ██   ██  ██████  ██   ██                                                     
                                     La precipitacion tiene que ser numerica. no se admiten caracteres especiales";
    string textop4 = @"
              
        
        
        
        
        
        
                                                
                                                
     
                                                          ███████ ██████  ██████   ██████  ██████      
                                                          ██      ██   ██ ██   ██ ██    ██ ██   ██     
                                                          █████   ██████  ██████  ██    ██ ██████      
                                                          ██      ██   ██ ██   ██ ██    ██ ██   ██     
                                                          ███████ ██   ██ ██   ██  ██████  ██   ██      
                                                  Precipitacion fuera de lo normal. intentelo de nuevo.";
    string textof1 = @"                        
        
        
        
        
        
        
        
        
        
        
                 --------------------------------Proceso finalizado. Presione Enter para Continuar---------------------------------";
    string textoc1 = @"                       
        
        
        
        
        
        
        
        
        
        
                           -----------------------------------REPORTE POR TEMPERATURA ------------------------------------";
    static string ObtenerClima(float mm, float temperatura)
    {
        // Nevado / Polar — temp < 10°C y frío/polar
        if (temperatura < 10)
            return @"
                                            Nevado / Polar
                                         *   .   *   .   *   .   *   .
                                           *   .   *   .   *   .   *
                                          .   *   .   *   .   *   .   *
                                           .   *   .   *   .   *   .    *
                                         *   .   *   .   *   .   *   .
                                           *   .   *   .   *   .   *  .
                                        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                                        = = = = = = = = = = = = = = = = =";

        // Soleado / Cálido — temp > 18°C y lluvia < 500mm
        if (temperatura > 18 && mm < 500)
            return @"
                                        Soleado / Cálido
                                          *  \    |    /  *
                                         .   \   |   /   .
                                          * ---`-----'--- *
                                          .  (   sol   )  .
                                          * ---`-----'--- *
                                          .   /   |   \   .
                                          *  /    |    \  *";

        // Árido / Desértico — temp > 18°C y lluvia < 250mm
        if (temperatura > 18 && mm < 250)
            return @"
                                        Árido / Desértico
                                          *  \    |    /  *
                                          .   \   |   /   .
                                          * ---`-----'--- *
                                          .  (   sol   )  .
                                          * ---`-----'--- *
                                          .   /   |   \   .
                                          *  /    |    \  *
                                        ============================
                                        . . . . tierra seca . . . .        ";

        // Nublado / Templado — 10–18°C y 250–500mm
        if (temperatura >= 10 && temperatura <= 18 && mm >= 250 && mm <= 500)
            return @"
                                        Nublado / Templado
                                       .-~~~-.    .-~~~~~-.
                                      ( nubes  )  ( nubes  )
                                       `-~~~-'    `-~~~~~-'
                                      .-~~~~~~~~~~~~~~~~~~~~~~-.
                                     (                          )
                                     (    cielo muy cubierto    )
                                     (                          )
                                      `-~~~~~~~~~~~~~~~~~~~~~~-'
                                      ~  ~  ~  ~  ~  ~  ~  ~  ~       ";

        // Lluvioso moderado — 500–2000mm
        if (mm > 500 && mm <= 2000)
            return @"
                                    Lluvioso moderado
                                      .--~~~~~~~~~~~~~~~~~~~~~~~~--.
                                     (                              )
                                     (     nubes de lluvia          )
                                     (                              )
                                      `--~~~~~~~~~~~~~~~~~~~~~~~~--'
                                       | | | | | | | | | | | | | |
                                        | | | | | | | | | | | | |
                                       | | | | | | | | | | | | | |
                                        | | | | | | | | | | | | |        ";

        // Tormenta / Lluvia fuerte — > 2000mm
        if (mm > 2000)
            return @"
                                    Tormenta / Lluvia fuerte
                                      #################################
                                      # # # nubes muy oscuras  # # # #
                                     # # #                    # # # #
                                     #################################
                                       /  /  /  \ /  /  /  /  \ /
                                       /  / \ /  /  \ /  /  /  /  \
                                     /  /  /  \  /  /  /  /  /  \
                                     /  / \ /  /  /  \ /  /  \ /  /       ";

        return "sin datos";
    }

    //---------------------------------------------------------hola

    ConsoleColor[] colores = {
    ConsoleColor.Red,
    ConsoleColor.Yellow,
    ConsoleColor.Green,
    ConsoleColor.Cyan,
    ConsoleColor.Blue,
    ConsoleColor.Magenta,
    ConsoleColor.White
};

    string mensaje = @" 
                                        ░██████  ░██ ░██                                                                                     
                                       ░██   ░██ ░██                                                                                         
                                      ░██        ░██ ░██░█████████████   ░███████   ░████████ ░██░████  ░██████   ░█████████████   ░██████   
                                      ░██        ░██ ░██░██   ░██   ░██ ░██    ░██ ░██    ░██ ░███           ░██  ░██   ░██   ░██       ░██  
                                      ░██        ░██ ░██░██   ░██   ░██ ░██    ░██ ░██    ░██ ░██       ░███████  ░██   ░██   ░██  ░███████  
                                       ░██   ░██ ░██ ░██░██   ░██   ░██ ░██    ░██ ░██   ░███ ░██      ░██   ░██  ░██   ░██   ░██ ░██   ░██  
                                        ░██████  ░██ ░██░██   ░██   ░██  ░███████   ░█████░██ ░██       ░█████░██ ░██   ░██   ░██  ░█████░██ 
                                                                                          ░██                                                
                                                                                    ░███████                                                 
                                                                                                       
                                                                                   ";
    Random rnd = new Random();

    do
    {
        Console.Clear();
        Console.ForegroundColor = colores[rnd.Next(colores.Length)];
        Console.WriteLine(mensaje);
        Console.WriteLine("                                                     Presiona Enter para ingresar ");
        Thread.Sleep(200);

    } while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter));

    Console.ResetColor();
    Console.Clear();
    float[] temp = new float[12];
    float[] presipitacion = new float[12];
    string[] temptipo = new string[12];
    string[] prestipo = new string[12];
    string[] meses = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

    do
    {
        for (int i = 0; i < 12; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine(bim);
            Console.ResetColor();
            Console.WriteLine("                                                       Ingresa la temperatura del mes " + meses[i]);
            string temperatura = Console.ReadLine();
            Console.Clear();
            if (float.TryParse(temperatura, out temp[i]))
            {
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine(texto);
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
                Console.ResetColor();
                Console.Clear();
                i--;
                continue;
            }

            if (temp[i] > 57 || temp[i] < -89)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine(texto2);
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
                Console.ResetColor();
                Console.Clear();
                i--;
                continue;
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(textop);
        Console.ResetColor();
    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    Console.Clear();

    do
    {
        for (int i = 0; i < 12; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine(textop2);
            Console.ResetColor();
            Console.WriteLine("                                                          Ingresa la presipitacion del mes " + meses[i]);
            string presipitacio = Console.ReadLine();
            Console.Clear();
            if (float.TryParse(presipitacio, out presipitacion[i]))
            {
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine(textop3);
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
                Console.ResetColor();
                Console.Clear();
                i--;
                continue;
            }

            if (presipitacion[i] > 1825 || presipitacion[i] < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine(textop4);
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
                Console.ResetColor();
                Console.Clear();
                i--;
                continue;
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(textof1);
        Console.ResetColor();
    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    Console.Clear();

    do
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(textoc1);
        Console.ResetColor();
        for (int i = 0; i < 12; i++)
        {
            if (temp[i] < 10)
            {
                temptipo[i] = "                                  fríos/polares";
                Console.ForegroundColor = ConsoleColor.Cyan; // Azul para frío
            }
            else if (temp[i] >= 10 && temp[i] <= 18)
            {
                temptipo[i] = "                                   templados";
                Console.ForegroundColor = ConsoleColor.Green; // Verde para templado
            }
            else
            {
                temptipo[i] = "                                    cálido";
                Console.ForegroundColor = ConsoleColor.Red; // Rojo para cálido
            }

            Console.WriteLine($" MES: {meses[i]} / {temp[i]}°C ({temptipo[i]})");
            Console.ResetColor(); // El dibujo se queda en color normal para que se aprecie el ASCII
            Console.WriteLine(ObtenerClima(presipitacion[i], temp[i]));
            Console.WriteLine("-------------------------------------------------------------");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"                                -------------------------Temperaturas Finaliozada - Presione ENTER para ver Precipitaciones-------------------------");
        Console.ResetColor();
    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);

    Console.Clear();


    Console.Clear();
    do
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                       ------------------------------------ REPORTE POR PRECIPITACIÓN  -----------------------------------------");
        Console.ResetColor();
        for (int i = 0; i < 12; i++)
        {
            if (presipitacion[i] < 250)
            {
                prestipo[i] = "deserticos";
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Color tierra
            }
            else if (presipitacion[i] >= 250 && presipitacion[i] <= 500)
            {
                prestipo[i] = "arido";
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (presipitacion[i] > 500 && presipitacion[i] <= 2000)
            {
                prestipo[i] = "moderadamente lluvioso";
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                prestipo[i] = "excesivamente lluvioso";
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }

            Console.WriteLine($"                              MES: {meses[i]} / Lluvia: {presipitacion[i]} MM");
            Console.WriteLine($"Estado: {prestipo[i]}");
            Console.ResetColor();

            // Dibujo ASCII
            Console.WriteLine(ObtenerClima(presipitacion[i], temp[i]));
            Console.WriteLine("                         ---------------------------------------------------------------");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Precipitacion terminada, Presione ENTER para continuar.");
        Console.ResetColor();
    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    Console.Clear();

    do
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                     --------------------------------Mes con mayor y menor temperatura---------------------------------");
        Console.ResetColor();
        float temperatura_mayor = -10000000;
        string maximo_mes = "";
        for (int i = 0; i < 12; i++)
        {
            if (temp[i] > temperatura_mayor)
            {
                temperatura_mayor = temp[i];
                maximo_mes = meses[i];
            }
        }
        Console.WriteLine("                                            La  temperatura mayor   es  " + temperatura_mayor + "  del mes  " + maximo_mes);

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
        Console.WriteLine("                                            La  temperatura menor   es  " + temperatura_menor + "  del mes  " + menor_mes);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"                                     --------------------------------Proceso finalizado. Presione Enter para Continuar---------------------------------");
        Console.ResetColor();
    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    Console.Clear();

    do
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                     --------------------------------Meses con mayor y menor Presipitacion---------------------------------");
        Console.ResetColor();
        float presipitacion_mayor = -10000000;
        string maximop_mes = "";
        for (int i = 0; i < 12; i++)
        {
            if (presipitacion[i] > presipitacion_mayor)
            {
                presipitacion_mayor = presipitacion[i];
                maximop_mes = meses[i];
            }
        }
        Console.WriteLine("                                    La  presipitacion mayor   es  " + presipitacion_mayor + "  del mes  " + maximop_mes);

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
        Console.WriteLine("                                    La  presipitacion menor   es  " + presipitacion_menor + "  del mes  " + menorp_mes);


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"                                     --------------------------------Proceso finalizado. Presione Enter para Continuar---------------------------------");
        Console.ResetColor();
    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    Console.Clear();


    //---------------------------------promedio anual
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("                                     --------------------------------Promedio anual---------------------------------");
    Console.ResetColor();
    float total = 0;
    for (int i = 0; i < 12; i++)
    {
        total = total + temp[i];
    }
    float promedio_temp = total / 12;
    Console.WriteLine($"                                    La temperatura promedio del año es {promedio_temp}");

    float totalpresi = 0;
    for (int i = 0; i < 12; i++)
    {
        totalpresi = totalpresi + presipitacion[i];
    }
    Console.WriteLine($"                                    La presipitacion total del año es {totalpresi}");

    Console.ReadKey();



    Console.WriteLine("                                    desea continuar con el programa. presione cualquier letra para salir y  para seguir");
    continuar = Console.ReadLine();
}

