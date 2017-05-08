using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesAggregateSettings class
    /// </summary>
    public partial class ChartSeriesAggregateSettings<T> where T : class 
    {
        public ChartSeriesAggregate? Close { get; set; }
        public ClientHandlerDescriptor CloseHandler { get; set; }

        public ChartSeriesAggregate? High { get; set; }
        public ClientHandlerDescriptor HighHandler { get; set; }

        public ChartSeriesAggregate? Low { get; set; }
        public ClientHandlerDescriptor LowHandler { get; set; }

        public ChartSeriesAggregate? Open { get; set; }
        public ClientHandlerDescriptor OpenHandler { get; set; }

        public ChartSeriesAggregate? Lower { get; set; }
        public ClientHandlerDescriptor LowerHandler { get; set; }

        public ChartSeriesAggregate? Mean { get; set; }
        public ClientHandlerDescriptor MeanHandler { get; set; }

        public ChartSeriesAggregate? Median { get; set; }
        public ClientHandlerDescriptor MedianHandler { get; set; }

        public ChartSeriesAggregate? Outliers { get; set; }
        public ClientHandlerDescriptor OutliersHandler { get; set; }

        public ChartSeriesAggregate? Q1 { get; set; }
        public ClientHandlerDescriptor Q1Handler { get; set; }

        public ChartSeriesAggregate? Q3 { get; set; }
        public ClientHandlerDescriptor Q3Handler { get; set; }

        public ChartSeriesAggregate? Upper { get; set; }
        public ClientHandlerDescriptor UpperHandler { get; set; }
        
        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (CloseHandler?.HasValue() == true)
            {
                settings["close"] = CloseHandler;
            }
            else if (Close.HasValue)
            {
                settings["close"] = Close?.Serialize();
            }


            if (HighHandler?.HasValue() == true)
            {
                settings["high"] = HighHandler;
            }
            else if (High.HasValue)
            {
                settings["high"] = High?.Serialize();
            }


            if (LowHandler?.HasValue() == true)
            {
                settings["low"] = LowHandler;
            }
            else if (Low.HasValue)
            {
                settings["low"] = Low?.Serialize();
            }


            if (OpenHandler?.HasValue() == true)
            {
                settings["open"] = OpenHandler;
            }
            else if (Open.HasValue)
            {
                settings["open"] = Open?.Serialize();
            }


            if (LowerHandler?.HasValue() == true)
            {
                settings["lower"] = LowerHandler;
            }
            else if (Lower.HasValue)
            {
                settings["lower"] = Lower?.Serialize();
            }


            if (MeanHandler?.HasValue() == true)
            {
                settings["mean"] = MeanHandler;
            }
            else if (Mean.HasValue)
            {
                settings["mean"] = Mean?.Serialize();
            }


            if (MedianHandler?.HasValue() == true)
            {
                settings["median"] = MedianHandler;
            }
            else if (Median.HasValue)
            {
                settings["median"] = Median?.Serialize();
            }


            if (OutliersHandler?.HasValue() == true)
            {
                settings["outliers"] = OutliersHandler;
            }
            else if (Outliers.HasValue)
            {
                settings["outliers"] = Outliers?.Serialize();
            }


            if (Q1Handler?.HasValue() == true)
            {
                settings["q1"] = Q1Handler;
            }
            else if (Q1.HasValue)
            {
                settings["q1"] = Q1?.Serialize();
            }


            if (Q3Handler?.HasValue() == true)
            {
                settings["q3"] = Q3Handler;
            }
            else if (Q3.HasValue)
            {
                settings["q3"] = Q3?.Serialize();
            }


            if (UpperHandler?.HasValue() == true)
            {
                settings["upper"] = UpperHandler;
            }
            else if (Upper.HasValue)
            {
                settings["upper"] = Upper?.Serialize();
            }


            return settings;
        }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            // Do manual serialization here

            return settings;
        }
    }
}
