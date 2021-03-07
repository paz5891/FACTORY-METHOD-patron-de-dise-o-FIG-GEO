using System;
using System.Threading;

namespace factory_method
{   
    //................................................................................
    //Area Class
    abstract class Area
    {
        public abstract IFigure FactoryMethod();
        public string SendFigure(){
            var figure=FactoryMethod();
            return figure.CreateFigure();
        }
    }
    //................................................................................
    //Area rectangulo
    class AreaRectangulo: Area
    {
        public override IFigure FactoryMethod()
        {
            return new FiguraAreaRectangulo();
        }
    }

    //................................................................................
    //Area cuadrado
    class AreaCuadrado: Area
    {
        public override IFigure FactoryMethod()
        {
            return new FiguraAreaCuadrado();
        }
    }

    //................................................................................
    //Area triangulo
    class AreaTriangulo: Area
    {
        public override IFigure FactoryMethod()
        {
            return new FiguraAreaTriangulo();
        }
    }
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Figura Class
    public interface IFigure
    {
        string CreateFigure();
    }
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Figura Cuadrado Class
    class FiguraAreaCuadrado: IFigure
    {
        public string CreateFigure()
        {
            return @"Beginning ...                                       
                                                                 .___                  .___      
                                          ____  __ _______     __| _/___________     __| _/____  
                                        _/ ___\|  |  \__  \   / __ |\_  __ \__  \   / __ |/  _ \ 
                                        \  \___|  |  // __ \_/ /_/ | |  | \// __ \_/ /_/ (  <_> )
                                         \___  >____/(____  /\____ | |__|  (____  /\____ |\____/ 
                                             \/           \/      \/            \/      \/       
        }
    }
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Figura Rectangulo Class
    class FiguraAreaRectangulo: IFigure
    {
        public string CreateFigure(){
            return @"Beginning ...                                   
                                                               __                              .__          
                                        _______   ____   _____/  |______    ____    ____  __ __|  |   ____  
                                        \_  __ \_/ __ \_/ ___\   __\__  \  /    \  / ___\|  |  \  |  /  _ \ 
                                         |  | \/\  ___/\  \___|  |  / __ \|   |  \/ /_/  >  |  /  |_(  <_> )
                                         |__|    \___  >\___  >__| (____  /___|  /\___  /|____/|____/\____/ 
                                                    \/     \/          \/     \//_____/                    
        }
    }
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Figura Triangulo Class
    class FiguraAreaTriangulo: IFigure
    {
        public string CreateFigure(){
            return @"Beginning ...   
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
            Console.WriteLine("Solicitando creacion rectangulo");
            Thread.Sleep(2000);
            CreateFigure(new AreaRectangulo());
            Thread.Sleep(2000);
            Console.WriteLine("PRUEBA # 2");
            Thread.Sleep(2000);
            Console.WriteLine("Solicitando creacion cuadrado");
            Thread.Sleep(2000);
            CreateFigure(new AreaCuadrado());
            Thread.Sleep(2000);
            Console.WriteLine("PRUEBA # 3");
            Thread.Sleep(2000);
            Console.WriteLine("Solicitando creacion triangulo");
            Thread.Sleep(2000);
            CreateFigure(new AreaTriangulo());
            Thread.Sleep(2000);
            Console.WriteLine("Amazing!!!!!!");
        }
        public static void CreateFigure(Area obj)
        {
            Console.WriteLine(obj.SendFigure());
        }
    }
}

