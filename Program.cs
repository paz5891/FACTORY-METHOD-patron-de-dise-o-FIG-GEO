using System;
using System.Threading;


namespace factory_method
{   
    //Logistic Class (Comentario)
    // abstract class Logistic

    //Figura Class
    abstract class Figura

    {
        public abstract ITransport FactoryMethod();
        public string SendRoute(){
            var transport=FactoryMethod();
            return transport.StartRoute();
        }
    }
    //................................................................................
    //Fabrica rectangulo
    class LogisticRoad: Logistic
    {
        public override ITransport FactoryMethod()
        {
            return new TransportRoad();
        }
    }


        class Rectangulo:Figura
        {
        private int lado2;

        public int Lado2 {
        set {
        if (value < 0)
        {
        lado2 = 0;
        }
        else {
        lado2 = value;
        }
        }
        get {
        return lado2;
        }
        }
        public Rectangulo(int lado1, int lado2) {
        this.Lado1 = lado1;
        this.Lado2 = lado2;
        }
        public override float area()
        {
        return Lado1 * Lado2;
        }
        public override float perimetro()
        {
        return (2 * Lado1) + (2 * Lado2);
        }
        }


    //................................................................................
    //Fabrica rectangulo


    class LogisticSea: Logistic
    {
        public override ITransport FactoryMethod()
        {
            return new TransportSea();
        }
    }
    class LogisticAir: Logistic
    {
        public override ITransport FactoryMethod()
        {
            return new TransportAir();
        }
    }

    //Transport Class (Comentario)
    // public interface ITransport
    // {
    //     string StartRoute();
    // }

    //Figura Class
    public interface IFigure
    {
        string CreateFigure();
    }


    class TransportRoad: ITransport
    {
        public string StartRoute()
        {
            return @"Beginning Road Route                                       
                                                                 .___                  .___      
                                          ____  __ _______     __| _/___________     __| _/____  
                                        _/ ___\|  |  \__  \   / __ |\_  __ \__  \   / __ |/  _ \ 
                                        \  \___|  |  // __ \_/ /_/ | |  | \// __ \_/ /_/ (  <_> )
                                         \___  >____/(____  /\____ | |__|  (____  /\____ |\____/ 
                                             \/           \/      \/            \/      \/       
        }
    }



    class TransportSea: ITransport
    {
        public string StartRoute(){
            return @"Beginning Sea Route                                    
                                                               __                              .__          
                                        _______   ____   _____/  |______    ____    ____  __ __|  |   ____  
                                        \_  __ \_/ __ \_/ ___\   __\__  \  /    \  / ___\|  |  \  |  /  _ \ 
                                         |  | \/\  ___/\  \___|  |  / __ \|   |  \/ /_/  >  |  /  |_(  <_> )
                                         |__|    \___  >\___  >__| (____  /___|  /\___  /|____/|____/\____/ 
                                                    \/     \/          \/     \//_____/                    
        }
    }
    class TransportAir: ITransport
    {
        public string StartRoute(){
            return @"Beginning Sea Route   
                                          __         .__                            .__          
                                        _/  |________|__|____    ____    ____  __ __|  |   ____  
                                        \   __\_  __ \  \__  \  /    \  / ___\|  |  \  |  /  _ \ 
                                         |  |  |  | \/  |/ __ \|   |  \/ /_/  >  |  /  |_(  <_> )
                                         |__|  |__|  |__(____  /___|  /\___  /|____/|____/\____/ 
                                                             \/     \//_____/                    
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Como utilizamos el patron de diseño de Factory Method.
            Console.WriteLine("PRUEBA # 1");
            Thread.Sleep(2000);
            Console.WriteLine("Solicitando transporte terrestre");
            Thread.Sleep(2000);
            StartRoute(new LogisticRoad());
            Thread.Sleep(2000);
            Console.WriteLine("PRUEBA # 2");
            Thread.Sleep(2000);
            Console.WriteLine("Solicitando transporte maritimo");
            Thread.Sleep(2000);
            StartRoute(new LogisticSea());
            Thread.Sleep(2000);
            Console.WriteLine("PRUEBA # 3");
            Thread.Sleep(2000);
            Console.WriteLine("Solicitando transporte Aereo");
            Thread.Sleep(2000);
            StartRoute(new LogisticAir());
            Thread.Sleep(2000);
            Console.WriteLine("Buen viaje!!!!!!");
        }
        public static void StartRoute(Logistic obj)
        {
            Console.WriteLine(obj.SendRoute());
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3Figuras
{
   abstract class Figura
    {
        private int lado1;
        public int Lado1 {
            set {
                if (value < 0) {
                    lado1 = 0;
                }
                else
                {
                    lado1 = value;
                }
            }
            get{
            return lado1;
            }
        }
       public abstract float area();
       public abstract float perimetro();
    }

}

class Rectangulo:Figura
{
private int lado2;

public int Lado2 {
set {
if (value < 0)
{
lado2 = 0;
}
else {
lado2 = value;
}
}
get {
return lado2;
}
}
public Rectangulo(int lado1, int lado2) {
this.Lado1 = lado1;
this.Lado2 = lado2;
}
public override float area()
{
return Lado1 * Lado2;
}
public override float perimetro()
{
return (2 * Lado1) + (2 * Lado2);
}
}

class Cuadrado:Figura
    {
        public Cuadrado(int lado1) {
            this.Lado1 = lado1;
        }
        public override float area()
        {
            return Lado1 * Lado1;
        }
        public override float perimetro()
        {
            return 4 * Lado1;
        }
    }

class Triangulo:Figura
    {
        private int lado2;
        private int lado3;

        public int Lado2 {
        
            set {
                if (value < 0) {
                    lado2 = 0;
                }
                else{
                lado2=value;
                }
            }
            get {
                return lado2;
            }
        }

        public int Lado3 {
            set {
                if (value < 0)
                {
                    lado3 = 0;
                }
                else {
                    lado3 = value;
                }
            }
            get {
                return lado3;
            }
        }
        public Triangulo(int tbase, int altura) {
            Lado1 = tbase;
            Lado2 = altura;
        }
        public Triangulo(int L1, int L2, int L3) {
            Lado1 = L1;
            Lado2 = L2;
            Lado3 = L3;
        }
        public override float area()
        {
            return (Lado1 * Lado2) / 2.0F;
        }
        public override float perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}