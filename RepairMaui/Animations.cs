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
        public static async Task BackColorAndScaleBlink(View element, Color c1, Color c2, double scale1, double scale2)
        {
            await Task.WhenAll(
                element.BackgroundColorTo(c2, length: 200, easing: Easing.Linear),
                element.ScaleTo(scale2, length: 200, easing: Easing.Linear)
            );
            await Task.WhenAll(
                element.BackgroundColorTo(c1, length: 200, easing: Easing.Linear),
                element.ScaleTo(scale1, length: 200, easing: Easing.Linear)
            );
        }
    }
}
