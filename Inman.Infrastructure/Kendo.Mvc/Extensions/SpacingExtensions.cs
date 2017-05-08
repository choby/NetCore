using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.Extensions
{
    public static class SpacingExtensions
    {
        public static void All(this ISpacing spacing, double margin)
        {
            spacing.Top = margin;
            spacing.Right = margin;
            spacing.Bottom = margin;
            spacing.Left = margin;
        }
    }
}