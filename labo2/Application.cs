using System.Collections;

namespace labo2;

public abstract class Application
{
    public abstract List<Document> CreateDocument();
    public abstract List<Factory> CreateFactory();

}