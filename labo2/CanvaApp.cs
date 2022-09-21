namespace labo2;

public class CanvaApp : Application
{
    public override List<Document> CreateDocument()
    {
        List<Document> newDoc = new List<Document>();
        newDoc.Add(new CanvaDoc());
        return newDoc;
    }

    public override List<Factory> CreateFactory()
    {
        List<Factory> newFac = new List<Factory>();
        newFac.Add(new CanvaFactory());
        return newFac;
    }
}