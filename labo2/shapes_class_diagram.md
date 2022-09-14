# Diagramme de classes avec PlantUML

## ShapesLib

- Engin de rendu différent
[https://plantuml.com/fr/graphviz-dot](https://plantuml.com/fr/graphviz-dot)
  - ajouter la ligne suivante après la ligne `@startuml` 
  
    `!pragma layout smetana`

### Diagramme de classes V1

[plantuml.com](https://www.plantuml.com/plantuml/uml/ZPBFRjmW4CRlF0NQarqtKl_SgXnIRGwfj8SgMxdjaU396jMBNHYdKhVxxiLCPec58_bW6BvlO7w6kV6e78x7JlXVnWxAgQFKdVB-Cw8p3oF25ztRlVaByfrG3nwTqaWPSj-g0UH9I7aAfw3HPrdTmgCQExnrwi-sxtedFyauXwHgKOo756KAepEjJrpkJ5kBhR9FofTXzrDl6d4MWZY-ziPYvAX-13Cifl3dSrX5kmZVssbTpeGuK4NMurYAnPBL3km1swAaimC2tS7rlwihmc2ckvsn49YgxwR1bb6YIXK89fSOXvquBkFCoyT4GNUnUR-Hrq7RlDcG7dR4XsQycl7km1nQPBuwuyiavcEdNijNly9NB_4ntilYz32vnaXihGLwoVCXyJpZW6s6oVECzCqPPGzTnE9uXi64kRq8cx8uM0FDkGp-CO6pDUq3XqR3XVqUD9ANTUJi_IzvJ9uQ8VVoZaWf7AtvfqINTqVomivn6C3juF7I9VlVetBvFv4yQ-EaPTHiqRI6bp9pM38MIRV6QRhzUzMOqJCgwNDKrd9KjcXQWqgPEIeP4we6Y-343TXcF7R_0G00)

![

### Diagramme de classe V4

[plantuml](https://www.plantuml.com/plantuml/uml/ZPDVZn8n5CNV-oagJumZHDqtGyWQrcHDU32BeZvsXouq3Xrixwn_aEzkvvP3IOTize7spZdj_4uldMjFob6xhSKBskYjbfMZqTffRON_OUnEERMLLQsyVq_ap7rB-cFLs8Nvg-Lh8TYHYutQQJcPg7jFJbKqdSgzs7jIPAg3B6_qWsfhkd7grwof6oVVIPv5UK7YTmqB5AmMOezN7oHl6iwKVLI-2FiU6xCI1qJvr1XBWLv-2rOeHVaT1Ll3y7lLFHUP48R8WivZ8IxYohcsQzeCY_ZkW3-suDze52CWp-tSMDtb-MfMj44KLYC1ON89SU3mM0HIDqSGIm0j0RhLPhqXa9OvgI-116VP9x444a0BKgxZnFEM7-mgFPmZqCXS0nWMOo_t-xo_p4z_T_rdtTWkph4SZiTZ47Cf0U7CZQS9UzFBQd_BSNv6KgGJyL8EhiRZbmCv6JLo46P43nkr8rDfZqDzTaRPTSrDNWPF_tw3pa9ucmjNIS3shDTeoXDsQb1QXQAx48ZCXuE1r7UwebFiBxkTTdFzaEx7-GUGNr9iFMN2K3pXfQnf2Qf-MZYdk8kVhNASbQli6qbQJeF54tFImPaK3M1cnbMn9JDjIRlKZpkrCgr72tXT5W9QFmIiE3tdAiQLGbnhksgtzNy0)

![V4](images/v4.png)

````plantuml
@startuml

namespace ShapesLibCanva{

skinparam classAttributeIconSize 0

abstract class ShapeCanva {
{abstract} +Draw(Canvas) : void
}

class Point {
+X : int
+Y : int
+Point(int, int)
+Point(int, int, Color)
+Point(Point)
+Draw(Canvas) : void
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
+Draw(Canvas) : void
}
ShapeCanva <|-- Line

class Polygon {
+Polygon(...Point)
+Polygon(...Point, Color)
+Polygon(List<Point>)
+Polygon(List<Point>, Color)
+Polygon(Polygon)
+Draw(Canvas) : void
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
+Draw(Canvas) : void
}
ShapeCanva <|-- Circle
labo2.Shape <|-- ShapeCanva

class Canva{
  +DefaultWidth: int
  +DefaultHeight: int 
  +DefaultBackground: Color
  +Width : int
  +Height : int
  +Background : Color
  
  
  +Canva()
  +Canva(int)
  +Canva(int,int)
  +Canva(int,int,Color)
  
  +Clear(Color) : void
  +getPixel(int,int) : Color
  +setPixel(int,int,Color):
  +Save(string) : void
}

}





namespace ShapesLibAscii {

skinparam classAttributeIconSize 0

abstract class ShapeAscii {
{abstract} +Draw(Ascii) : void
}

class Point {
+X : int
+Y : int
+Point(int, int)
+Point(int, int, Color)
+Point(Point)
+Draw(Canvas) : void
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
+Draw(Canvas) : void
}
ShapeAscii <|-- Line

class Polygon {
+Polygon(...Point)
+Polygon(...Point, Color)
+Polygon(List<Point>)
+Polygon(List<Point>, Color)
+Polygon(Polygon)
+Draw(Canvas) : void
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
+Draw(Canvas) : void
}
ShapeAscii <|-- Circle
labo2.Shape <|-- ShapeAscii


class Ascii{
  +DefaultWidth: int
  +DefaultHeight: int 
  +DefaultBackground: Color
  +Width : int
  +Height : int
  +Background : Color
  
  
  +Ascii()
  +Ascii(int)
  +Ascii(int,int)
  +Ascii(int,int,Color)
  
  +Clear(Color) : void
  +getPixel(int,int) : Color
  +setPixel(int,int,Color):
  +Save(string) : void
}
}






namespace labo2{

Abstract class Shape{
  {static} +DefaultDrawColor : Color
  +DrawColor : Color
  +Shape()
  +Shape(Color)
}


Abstract class Fabric {

  -ArrayList<Shape> CurrentShapes
  
  +Fabric(int):void
  +AddLine():void
  +AddCircle():void
  +addHline():void
  +addVline():void
  +addRectangle():void
  +addTriangle():void
  +SaveFile():void
}
Fabric "1" --> "0..*"Shape

class AsciiFabric{
}
Fabric <|-- AsciiFabric
ShapesLibAscii.Ascii --> AsciiFabric
class CanvaFabric{
}
Fabric <|-- CanvaFabric
ShapesLibCanva.Canva --> CanvaFabric


}














@enduml
````