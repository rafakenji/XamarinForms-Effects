using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamFormEffect.Effects
{
    public class FocusEffect : RoutingEffect
    {
        public Color Color { get; set; }

        public Color ColorBefore { get; set; }

        public FocusEffect() : base("K1IT.FocusEffect")
        {

        }
    }
}
