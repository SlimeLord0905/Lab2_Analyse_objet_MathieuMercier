using labo2;
public class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        List<Application> currentApp = new List<Application>();
        List<Document> CurrentDoc = new List<Document>();
        List<Factory> CurrentFac = new List<Factory>();
        while (!exit)
        {
           
            Console.WriteLine("Que voulez-vous faire?");
            Console.WriteLine("");
            Console.WriteLine("1- Créer un document Canva");
            Console.WriteLine("2- Créer un document Ascii");
            Console.WriteLine("3- Modifier le dernier Document");
            Console.WriteLine("4- Sauvegarder");
            Console.WriteLine("5- Quitter");
            Console.WriteLine("");

            string answer = Console.ReadLine();
            if (answer == "1" || answer == "2")
            {
                if (answer == "1")
                {
                    currentApp.Clear();
                    currentApp.Add(new CanvaApp());
                }
                else if (answer == "2")
                {
                    currentApp.Clear();
                    currentApp.Add(new AsciiApp());
                }
                CurrentDoc = currentApp.First().CreateDocument();
                CurrentFac = currentApp.First().CreateFactory();
            }
            else if (answer == "3")
            {
                bool exitedit = false;
                while (!exitedit)
                {
                    Console.WriteLine("Que voulez-vous Ajouter");
                    Console.WriteLine("");
                    Console.WriteLine("1- un point");
                    Console.WriteLine("2- une Ligne");
                    Console.WriteLine("3- une ligne horizontal");
                    Console.WriteLine("4- une ligne vertical");
                    Console.WriteLine("5- un rectangle (ou carré ou polygon)");
                    Console.WriteLine("6- un cercle");
                    Console.WriteLine("7- un triangle");
                    Console.WriteLine("8- Quitter");


                    string answerEdit = Console.ReadLine();
                    if (answerEdit == "1")
                    {
                        Console.WriteLine("Coordonner du point");
                        Console.WriteLine("x");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y1 = int.Parse(Console.ReadLine());
                        CurrentFac.First().addPoint(x1,y1);
                    }
                    else if (answerEdit == "2")
                    {
                        Console.WriteLine("Coordonner du début de la ligne");
                        Console.WriteLine("x");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Coordonner de la fin de la ligne");
                        Console.WriteLine("x");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y2 = int.Parse(Console.ReadLine());
                        currentApp.First().CurrentFactory.First().addLine(x1,y1,x2,y2);
                    }
                    else if (answerEdit == "3")
                    {
                        Console.WriteLine("Coordonner du début de la ligne");
                        Console.WriteLine("x");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Longueur de la ligne");
                        int width = int.Parse(Console.ReadLine());
                        currentApp.First().CurrentFactory.First().addHLine(x1,y1,width);
                    }
                    else if (answerEdit == "4")
                    {
                        Console.WriteLine("Coordonner du début de la ligne");
                        Console.WriteLine("x");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("hauteur de la ligne");
                        int height = int.Parse(Console.ReadLine());
                        currentApp.First().CurrentFactory.First().addHLine(x1,y1,height);
                    }
                    else if (answerEdit == "5")
                    {
                        Console.WriteLine("Coordonner du premier point");
                        Console.WriteLine("x");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Coordonner du deuxième point");
                        Console.WriteLine("x");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Coordonner du troisième point");
                        Console.WriteLine("x");
                        int x3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Coordonner du quatrième point");
                        Console.WriteLine("x");
                        int x4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y4 = int.Parse(Console.ReadLine());
                        currentApp.First().CurrentFactory.First().addRectangle(x1,y1,x2,y2,x3,y3,x4,y4);
                    }
                    else if (answerEdit == "6")
                    {
                        Console.WriteLine("Coordonner du centre du cercle");
                        Console.WriteLine("x");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("longueur du rayon du cercle");
                        int radius = int.Parse(Console.ReadLine());
                        currentApp.First().CurrentFactory.First().addCircle(x1,y1,radius);
                    }
                    else if (answerEdit == "7")
                    {
                        Console.WriteLine("Coordonner du premier point");
                        Console.WriteLine("x");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Coordonner du deuxième point");
                        Console.WriteLine("x");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Coordonner du troisième point");
                        Console.WriteLine("x");
                        int x3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y");
                        int y3 = int.Parse(Console.ReadLine());
                        currentApp.First().CurrentFactory.First().addTriangle(x1,y1,x2,y2,x3,y3);
                    }
                    else if (answerEdit == "8")
                    {
                        exitedit = true;
                    }
                    else
                    {
                        Console.WriteLine("entrer invalide");
                    }
                }
            }
            else if (answer == "4")
            {
                currentApp.First().CurrentFactory.First().saveFile(currentApp.First().CurrentDoc.First());
            }
            else if (answer == "5")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("enter invalide");
            }
        }
    }
}