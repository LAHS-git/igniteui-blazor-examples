﻿using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SampleScatterData
    {
        public static List<SampleScatterPoint> Create()
        {
            var data = new List<SampleScatterPoint>();
            var xMin = -180;
            var xMax = 180;
            var yMin = -90;
            var yMax = 90;
            var xCount = 11;
            var yCount = 11;

            var xStep = (xMax - xMin) / (xCount - 1);
            var yStep = (yMax - yMin) / (yCount - 1);
            var index = 0;
            for (var x = xMin; x <= xMax; x += xStep)
            {
                for (var y = yMin; y <= yMax; y += yStep)
                {
                    var z = Math.Cos(x) + Math.Cos(y);
                    var p = new SampleScatterPoint { X = x, Y = y, Z = z, Index = index++ };
                    data.Add(p);
                    Console.WriteLine("x=" + x + " y=" + y + " z=" + z);
                }
            }
            return data;
        }
    }

    public class SampleScatterPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Index { get; set; }
    }
}