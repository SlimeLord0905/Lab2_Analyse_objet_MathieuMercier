using System.Collections;
using labo2.ShapesLibAscii;

namespace labo2;

public class AsciiApp : Application
{
    public override List<Document> CreateDocument()
    {
        List<Document> newDoc = new List<Document>();
        newDoc.Add(new AsciiDoc());
        return newDoc;
    }

    public override List<Factory> CreateFactory()
    {
        List<Factory> newFac = new List<Factory>();
        newFac.Add(new AsciiFactory());
        return newFac;
    }
}

