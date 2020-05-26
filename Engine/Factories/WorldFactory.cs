using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field", 
                "there are rows of corn growing hre, with giant rats hiding between them", 
                "E:\\CSharp Projects\\SOSCSRPG\\Engine\\Images\\Locations\\FarmFields.png");

            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

            newWorld.AddLocation(0, -1, "Home", "This is your Home",
                "E:\\CSharp Projects\\SOSCSRPG\\Engine\\Images\\Locations\\Home.png");

            newWorld.AddLocation(-1, -1, "Farmers House",
                "This is a the hosue of your neighbor, Farmer Ted.",
                "E:\\CSharp Projects\\SOSCSRPG\\Engine\\Images\\Locations\\Farmhouse.png");

            newWorld.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan the trader.",
                "E:\\CSharp Projects\\SOSCSRPG\\Engine\\Images\\Locations\\Trader.png");

            newWorld.AddLocation(0, 0, "Town Square",
                "You see a fountain here.",
                "E:\\CSharp Projects\\SOSCSRPG\\Engine\\Images\\Locations\\TownSquare.png");

            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spides.",
                "E:\\CSharp Projects\\SOSCSRPG\\Engine\\Images\\Locations\\TownGate.png");

            newWorld.AddLocation(2, 0, "Spider Forest",
                "The tress in this forest are covered with spider webs",
                "E:\\CSharp Projects\\SOSCSRPG\\Engine\\Images\\Locations\\SpiderForest.png");

            newWorld.LocationAt(2, 0).AddMonster(3, 100);

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                "E:\\CSharp Projects\\SOSCSRPG\\Engine\\Images\\Locations\\HerbalistsHut.png");

            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with stankes hdiing behind them",
                "E:\\CSharp Projects\\SOSCSRPG\\Engine\\Images\\Locations\\sHerbalistsGarden.png");

            newWorld.LocationAt(0, 2).AddMonster(1, 100);

            return newWorld;
        }
    }
}
