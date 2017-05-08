namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of the note.
    /// </summary>
    public enum ChartNotePosition
    {
        /// <summary>
        /// The note is positioned on the top.
        /// </summary>
        Top,
        /// <summary>
        /// The note is positioned on the bottom.
        /// </summary>
        Bottom,
        /// <summary>
        /// The note is positioned on the left.
        /// </summary>
        Left,
        /// <summary>
        /// The note is positioned on the right.
        /// </summary>
        Right
    }

    internal static class ChartNotePositionExtensions
    {
        internal static string Serialize(this ChartNotePosition value)
        {
            switch (value)
            {
                case ChartNotePosition.Top:
                    return "top";
                case ChartNotePosition.Bottom:
                    return "bottom";
                case ChartNotePosition.Left:
                    return "left";
                case ChartNotePosition.Right:
                    return "right";
            }

            return value.ToString();
        }
    }
}

