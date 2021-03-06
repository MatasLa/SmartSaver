﻿using System.Drawing;

namespace ePiggy.Utilities
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
