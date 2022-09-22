using System.Collections;

namespace labo2;

public abstract class Application
{
    public List<Document> CurrentDoc = new List<Document>();
    public List<Factory> CurrentFactory = new List<Factory>();
    public abstract List<Document> CreateDocument();
    public abstract List<Factory> CreateFactory();

}