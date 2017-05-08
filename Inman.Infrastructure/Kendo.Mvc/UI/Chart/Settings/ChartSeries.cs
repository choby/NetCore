using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeries class
    /// </summary>
    public partial class ChartSeries<T> where T : class
    {
        public ChartSeriesAggregateSettings<T> Aggregates { get; } = new ChartSeriesAggregateSettings<T>();

        [Obsolete("This property is obsolete. Please use the CloseField property instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string CloseMember
        {
            get
            {
                return CloseField;
            }
            set
            {
                CloseField = value;
            }
        }

        public IEnumerable Data { get; set; }

        [Obsolete("This property is obsolete. Please use the HighField property instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string HighMember
        {
            get
            {
                return HighField;
            }
            set
            {
                HighField = value;
            }
        }

        [Obsolete("This property is obsolete. Please use the LowField property instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string LowMember
        {
            get
            {
                return LowField;
            }
            set
            {
                LowField = value;
            }
        }

        [Obsolete("This property is obsolete. Please use the OpenField property instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string OpenMember
        {
            get
            {
                return OpenField;
            }
            set
            {
                OpenField = value;
            }
        }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            var aggregates = Aggregates.Serialize();
            if (aggregates.Any())
            {
                settings["aggregate"] = aggregates;
            }

            if (Data != null)
            {
                settings["data"] = Data;
            }

            return settings;
        }
    }
}
