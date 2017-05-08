using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeScaleLabelsSettings
    /// </summary>
    public partial class RadialGaugeScaleLabelsSettingsBuilder
        
    {
        public RadialGaugeScaleLabelsSettingsBuilder(RadialGaugeScaleLabelsSettings container)
        {
            Container = container;
        }

        protected RadialGaugeScaleLabelsSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the labels margin
        /// </summary>
        /// <param name="top">The labels top margin.</param>
        /// <param name="right">The labels right margin.</param>
        /// <param name="bottom">The labels bottom margin.</param>
        /// <param name="left">The labels left margin.</param>      
        public RadialGaugeScaleLabelsSettingsBuilder Margin(int top, int right, int bottom, int left)
        {
            Container.Margin.Top = top;
            Container.Margin.Right = right;
            Container.Margin.Bottom = bottom;
            Container.Margin.Left = left;
            return this;
        }

        /// <summary>
        /// Sets the labels margin
        /// </summary>
        /// <param name="margin">The labels margin.</param>       
        public RadialGaugeScaleLabelsSettingsBuilder Margin(int margin)
        {
            Container.Margin.All(margin);
            return this;
        }

        /// <summary>
        /// Sets the labels padding
        /// </summary>
        /// <param name="top">The labels top padding.</param>
        /// <param name="right">The labels right padding.</param>
        /// <param name="bottom">The labels bottom padding.</param>
        /// <param name="left">The labels left padding.</param>    
        public RadialGaugeScaleLabelsSettingsBuilder Padding(int top, int right, int bottom, int left)
        {
            Container.Padding.Top = top;
            Container.Padding.Right = right;
            Container.Padding.Bottom = bottom;
            Container.Padding.Left = left;
            return this;
        }

        /// <summary>
        /// Sets the labels padding
        /// </summary>
        /// <param name="padding">The labels padding.</param>       
        public RadialGaugeScaleLabelsSettingsBuilder Padding(int padding)
        {
            Container.Padding.All(padding);
            return this;
        }

        /// <summary>
        /// Sets the labels border
        /// </summary>
        /// <param name="width">The labels border width.</param>
        /// <param name="color">The labels border color (CSS syntax).</param>
        /// <param name="dashType">The labels border dash type.</param>      
        public RadialGaugeScaleLabelsSettingsBuilder Border(int width, string color, ChartDashType dashType)
        {
            Container.Border.Width = width;
            Container.Border.Color = color;
            Container.Border.DashType = dashType;

            return this;
        }

        /// <summary>
        /// Sets the labels opacity.
        /// </summary>
        /// <param name="opacity">
        /// The series opacity in the range from 0 (transparent) to 1 (opaque).
        /// The default value is 1.
        /// </param>
        public RadialGaugeScaleLabelsSettingsBuilder Opacity(double opacity)
        {
            Container.Opacity = opacity;

            return this;
        }
    }
}
