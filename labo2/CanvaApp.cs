namespace labo2;

public class CanvaApp : Application
{
    public override List<Document> CreateDocument()
    {
        CurrentDoc.Clear();
        CurrentDoc.Add(new CanvaDoc());
        return CurrentDoc;
    }

    public override List<Factory> CreateFactory()
    {
        CurrentFactory.Clear();
        CurrentFactory.Add(new CanvaFactory());
        return CurrentFactory;
    }
}