﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderDemo.Models.Enums;

namespace BuilderDemo.Models
{
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = false;
            sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.CheeseType = CheeseType.Cheddar;
            sandwich.MeatType = MeatType.Turkey;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
            sandwich.IsToasted = true;
        }
    }
}
