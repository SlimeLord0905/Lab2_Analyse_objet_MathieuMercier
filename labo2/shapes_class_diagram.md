# Diagramme de classes avec PlantUML

## ShapesLib

- Engin de rendu différent
[https://plantuml.com/fr/graphviz-dot](https://plantuml.com/fr/graphviz-dot)
  - ajouter la ligne suivante après la ligne `@startuml` 
  
    `!pragma layout smetana`




### Diagramme de classe V4

[plantuml](https://www.plantuml.com/plantuml/uml/ZPDVZn8n5CNV-oagJumZHDqtGyWQrcHDU32BeZvsXouq3Xrixwn_aEzkvvP3IOTize7spZdj_4uldMjFob6xhSKBskYjbfMZqTffRON_OUnEERMLLQsyVq_ap7rB-cFLs8Nvg-Lh8TYHYutQQJcPg7jFJbKqdSgzs7jIPAg3B6_qWsfhkd7grwof6oVVIPv5UK7YTmqB5AmMOezN7oHl6iwKVLI-2FiU6xCI1qJvr1XBWLv-2rOeHVaT1Ll3y7lLFHUP48R8WivZ8IxYohcsQzeCY_ZkW3-suDze52CWp-tSMDtb-MfMj44KLYC1ON89SU3mM0HIDqSGIm0j0RhLPhqXa9OvgI-116VP9x444a0BKgxZnFEM7-mgFPmZqCXS0nWMOo_t-xo_p4z_T_rdtTWkph4SZiTZ47Cf0U7CZQS9UzFBQd_BSNv6KgGJyL8EhiRZbmCv6JLo46P43nkr8rDfZqDzTaRPTSrDNWPF_tw3pa9ucmjNIS3shDTeoXDsQb1QXQAx48ZCXuE1r7UwebFiBxkTTdFzaEx7-GUGNr9iFMN2K3pXfQnf2Qf-MZYdk8kVhNASbQli6qbQJeF54tFImPaK3M1cnbMn9JDjIRlKZpkrCgr72tXT5W9QFmIiE3tdAiQLGbnhksgtzNy0)

![V4](images/v4.png)

````plantuml
@startuml

namespace labo2{

Abstract class Shape{
  {static} +DefaultDrawColor : Color
  +DrawColor : Color
  +Shape()
  +Shape(Color)
}

Document "1" --> "0..*"Shape

Abstract class Factory{
  +AddLine():void
  +AddCircle():void
  +addHline():void
  +addVline():void
  +addRectangle():void
  +addTriangle():void
  +SaveFile(Document):Document

}
Factory <|-- CanvaFactory
class CanvaFactory{
}

Factory <|-- AsciiFactory
class AsciiFactory{
}


abstract class Document {
  +DefaultWidth: int
  +DefaultHeight: int 
  +DefaultBackground: Color
  +Width : int
  +Height : int
  +Background : Color
  
}


Document <|-- CanvasDoc
Document <|-- AsciiDoc

class CanvasDoc{
+currentDoc : Canvas
}
class AsciiDoc{
+currentDoc : Ascii
}

CanvasDoc --> labo2.ShapesLibCanva.Canva
AsciiDoc --> labo2.ShapesLibAscii.Ascii

abstract class Application {
  +CurrentDoc :Document
  +CurrentFactory : Factory
  +{abstract} CreateDocument() : Document
  +{abstract} CreateFactory() : Factory
}
Document "*" <-o "*" Application :docs  

class CanvasApp {
   +CreateDocument() : Document
   +CreateFactory() : Factory
}
Application <|-- CanvasApp
labo2.ShapesLibCanva.Canva <. CanvasApp
CanvaFactory <. CanvasApp

class AsciiApp {
   +CreateDocument() : Document
   +CreateFactory() : Factory

}
Application <|-- AsciiApp
labo2.ShapesLibAscii.Ascii <. AsciiApp
AsciiFactory <. AsciiApp




}





namespace labo2.ShapesLibCanva{

skinparam classAttributeIconSize 0
 
 class Canva{

  +Canva()
  +Canva(int)
  +Canva(int,int)
  +Canva(int,int,Color)
  
  +Clear(Color) : void
  +getPixel(int,int) : Color
  +setPixel(int,int,Color):
  +Save(string) : void
}

abstract class ShapeCanva {
{abstract} +Draw(Document) : void
}

class Point {
+X : int
+Y : int
+Point(int, int)
+Point(int, int, Color)
+Point(Point)
+Draw(Document) : void
+Length() : int
}
ShapeCanva <|-- Point

class HLine {
+Width : int
+HLine(Point, int)
+HLine(Point, int, Color)
+HLine(HLine)
}
Line <|-- HLine

class VLine {
+Height : int
+VLine(Point, int)
+VLine(Point, int, Color)
+VLine(VLine)
}
Line <|-- VLine

class Line {
+Start : Point
+End : Point
+Line(Point, Point)
+Line(Point, Point, Color)
+Line(Line)
+Draw(Document) : void
}
ShapeCanva <|-- Line

class Polygon {
+Polygon(...Point)
+Polygon(...Point, Color)
+Polygon(List<Point>)
+Polygon(List<Point>, Color)
+Polygon(Polygon)
+Draw(Document) : void
}
ShapeCanva <|-- Polygon
Point "3..*" <-o "*" Polygon : vertices

class Triangle {
+Vertex1 : Point
+Vertex2 : Point
+Vertex3 : Point
+Triangle(Point, Point, Point)
+Triangle(Point, Point, Point, Color)
+Triangle(Triangle)
}
Polygon <|-- Triangle

class Rectangle {
+UpperLeft : Point
+Width : int
+Height : int
+Rectangle(Point, int, int)
+Rectangle(Point, int, int, Color)
+Rectangle(Rectangle)
}
Polygon <|-- Rectangle

class Square {
+Square(Point, int)
+Square(Point, int, Color)
+Square(Square)
}
Rectangle <|-- Square

class Circle {
+Center : Point
+Radius : int
+Circle(Point, int)
+Circle(Point, int, Color)
+Circle(Circle)
+Draw(Document) : void
}
ShapeCanva <|-- Circle
labo2.Shape <|-- ShapeCanva


}





namespace labo2.ShapesLibAscii {

class Ascii{

  
  +Ascii()
  +Ascii(int)
  +Ascii(int,int)
  +Ascii(int,int,Color)
  
  +Clear(Color) : void
  +getPixel(int,int) : Color
  +setPixel(int,int,Color):
  +Save(string) : void
}

abstract class ShapeAscii {
{abstract} +Draw(Document) : void
}

class Point {
+X : int
+Y : int
+Point(int, int)
+Point(int, int, Color)
+Point(Point)
+Draw(Document) : void
+Length() : int
}
ShapeAscii <|-- Point

class HLine {
+Width : int
+HLine(Point, int)
+HLine(Point, int, Color)
+HLine(HLine)
}
Line <|-- HLine

class VLine {
+Height : int
+VLine(Point, int)
+VLine(Point, int, Color)
+VLine(VLine)
}
Line <|-- VLine

class Line {
+Start : Point
+End : Point
+Line(Point, Point)
+Line(Point, Point, Color)
+Line(Line)
+Draw(Document) : void
}
ShapeAscii <|-- Line

class Polygon {
+Polygon(...Point)
+Polygon(...Point, Color)
+Polygon(List<Point>)
+Polygon(List<Point>, Color)
+Polygon(Polygon)
+Draw(Document) : void
}
ShapeAscii <|-- Polygon
Point "3..*" <-o "*" Polygon : vertices

class Triangle {
+Vertex1 : Point
+Vertex2 : Point
+Vertex3 : Point
+Triangle(Point, Point, Point)
+Triangle(Point, Point, Point, Color)
+Triangle(Triangle)
}
Polygon <|-- Triangle

class Rectangle {
+UpperLeft : Point
+Width : int
+Height : int
+Rectangle(Point, int, int)
+Rectangle(Point, int, int, Color)
+Rectangle(Rectangle)
}
Polygon <|-- Rectangle

class Square {
+Square(Point, int)
+Square(Point, int, Color)
+Square(Square)
}
Rectangle <|-- Square

class Circle {
+Center : Point
+Radius : int
+Circle(Point, int)
+Circle(Point, int, Color)
+Circle(Circle)
+Draw(Document) : void
}
ShapeAscii <|-- Circle
labo2.Shape <|-- ShapeAscii



}


@enduml
````