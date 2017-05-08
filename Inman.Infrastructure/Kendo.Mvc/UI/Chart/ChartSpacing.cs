using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
    public class ChartSpacing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSpacing" /> class.
        /// </summary>
        /// <param name="margin">The spacing to be applied in all directions.</param>
        public ChartSpacing(int? margin)
        {
            Top = margin;
            Right = margin;
            Bottom = margin;
            Left = margin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSpacing" /> class.
        /// </summary>
        public ChartSpacing()
        {
        }

        /// <summary>
        /// Gets or sets the top spacing.
        /// </summary>
        public int? Top
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the right spacing.
        /// </summary>
        public int? Right
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the bottom spacing.
        /// </summary>
        public int? Bottom
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the left spacing.
        /// </summary>
        public int? Left
        {
            get;
            set;
        }

        public virtual Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            if (Top.HasValue)
            {
                settings["top"] = Top;
            }

            if (Bottom.HasValue)
            {
                settings["bottom"] = Bottom;
            }

            if (Left.HasValue)
            {
                settings["left"] = Left;
            }

            if (Right.HasValue)
            {
                settings["right"] = Right;
            }

            return settings;
        }
    }
}