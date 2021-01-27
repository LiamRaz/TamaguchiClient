using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tamaguchi.UI;
using Tamaguchi.UI.Screens;
using Tamaguchi.Models;

namespace Tamaguchi.UI.Screens
{
    class ActivitiesScreen : MenuScreen
    {
        public ActivitiesScreen() : base("Activities")
        {
            this.items = new List<MenuItem>();
            this.items.Add(new MenuItem("Cleaning", new CleaningScreen()));
            this.items.Add(new MenuItem("Feeding", new FeedingScreen()));
            this.items.Add(new MenuItem("Playing", new PlayingScreen()));
        }

    }
}
