﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralDesignPatterns.Flyweight.Model.Textures.Base;
using StructuralDesignPatterns.Flyweight.Model.Textures;

namespace StructuralDesignPatterns.Flyweight.Model.Trees
{
    class HawthornTree : Tree
    {
        public HawthornTree(double height = 0, double width = 0)
            : base(new SoftTexture(), ConsoleColor.Black, ConsoleColor.DarkGray, height, width)
        {
        }


        public override async Task Render()
        {
            if (!_alreadyRendered)
            {
                Console.WriteLine("HawthornTree - RENDER - START");
                await Task.Delay(356);
                Console.WriteLine("HawthornTree - RENDER - END");
                _alreadyRendered = true;
            }
            else
            {
                Console.WriteLine("HawthornTree : I'm already rendered - Flyweight is the best...");
            }
        }
    }
}
