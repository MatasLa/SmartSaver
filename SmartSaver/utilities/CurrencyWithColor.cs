using System.Drawing;

namespace ePiggy.utilities
{
    public readonly struct CurrencyWithColor
    {
        public string Number { get;  }

        public Color Color { get;  }

        public CurrencyWithColor(string number, Color color)
        {
            Number = number;
            Color = color;
        }
    }
}
