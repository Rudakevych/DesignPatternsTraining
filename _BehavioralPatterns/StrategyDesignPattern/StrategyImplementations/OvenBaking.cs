﻿using DesignPatternsTraining._BehavioralPatterns.StrategyDesignPattern.Abstract;
using System;

namespace DesignPatternsTraining._BehavioralPatterns.StrategyDesignPattern.StrategyImplementations
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    public class OvenBaking : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }
}
