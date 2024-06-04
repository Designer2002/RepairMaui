using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Extensions;
using Microsoft.Maui.Animations;

namespace RepairMaui
{
    internal class Animations
    {
        public async static Task FrameBgColorBlink(Frame frame, Color c1, Color c2)
        {
            await Task.WhenAll
            (
            frame.BackgroundColorTo(c2, length: 500, easing: Easing.Linear),
            frame.BackgroundColorTo(c1, length: 500, easing: Easing.Linear)
           );
        }
    }
}
