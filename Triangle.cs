using System;
using System.Collections.Generic;
using System.Text;

namespace KURSACH
{
    public class Triangle
    {
        public Triangle(Dot doti1, Dot doti2, Dot doti3)
        {
            dotA = doti1;
            dotB = doti2;
            dotC = doti3;
            coordinatesAB.x = dotB.x - dotA.x;
            coordinatesAB.y = dotB.y - dotA.y;
            coordinatesBC.x = dotC.x - dotB.x;
            coordinatesBC.y = dotC.y - dotB.y;
            coordinatesAC.x = dotC.x - dotA.x;
            coordinatesAC.y = dotC.y - dotA.y;
            lengthAB= Math.Sqrt((dotB.x - dotA.x) * (dotB.x - dotA.x) + (dotB.y - dotA.y) * (dotB.y - dotA.y));
            lengthBC= Math.Sqrt((dotC.x - dotB.x) * (dotC.x - dotB.x) + (dotC.y - dotB.y) * (dotC.y - dotB.y));
            lengthAC= Math.Sqrt((dotC.x - dotA.x) * (dotC.x - dotA.x) + (dotC.y - dotA.y) * (dotC.y - dotA.y));
            angleA=Math.Acos(Math.Abs(((dotB.x - dotA.x) * (dotC.x - dotA.x) + (dotB.y - dotA.y) * (dotC.y - dotA.y))) / (LengthAB * LengthAC)) * 180 / Math.PI;
            angleB=Math.Acos(Math.Abs(((dotC.x - dotB.x) * (dotB.x - dotA.x) + (dotC.y - dotB.y) * (dotB.y - dotA.y))) / (LengthAB * LengthBC)) * 180 / Math.PI;
            angleC= Math.Acos(Math.Abs(((dotC.x - dotA.x) * (dotC.x - dotB.x) + (dotC.y - dotA.y) * (dotC.y - dotB.y))) / (LengthAC * LengthBC)) * 180 / Math.PI;
            perimetr= LengthAB + LengthAC + LengthBC;
            area= (LengthAB * LengthAC * Math.Sin(AngleA / 180 * Math.PI)) / 2;
            radiusOfSmallCircle= 2 * Area / Perimetr;
            radiusOfBigCircle= LengthAB * LengthBC * LengthAC / (4 * Area);
        }
        private Dot dotA;
        private Dot dotB;
        private Dot dotC;
        private Dot coordinatesAB;
        private Dot coordinatesBC;
        private Dot coordinatesAC;
        private double lengthAB=0;
        private double lengthBC=0;
        private double lengthAC=0;
        private double angleA=0;
        private double angleB=0;
        private double angleC=0;
        private double perimetr=0;
        private double area=0;
        private double radiusOfSmallCircle=0;
        private double radiusOfBigCircle=0;
        public Dot CoordinatesAB => coordinatesAB;
        public Dot CoordinatesBC => coordinatesBC; 
        public Dot CoordinatesAC => coordinatesAC;
        public double LengthAB => lengthAB;
        public double LengthBC => lengthBC;
        public double LengthAC => lengthAC;
        public double AngleA => angleA;
        public double AngleB => angleB;
        public double AngleC =>angleC;
        public double Perimetr =>perimetr;
        public double Area => area; 
        public double RadiusOfSmallCircle => radiusOfSmallCircle;
        public double RadiusOfBigCircle => radiusOfBigCircle;
        

    };
}
