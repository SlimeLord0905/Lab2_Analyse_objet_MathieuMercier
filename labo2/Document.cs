using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using labo2.ShapesLibAscii;
using labo2.ShapesLibCanva;

namespace labo2;

public abstract class Document
{
   public Canvas CurentCanva;
   public Ascii CurrentAscii;
}