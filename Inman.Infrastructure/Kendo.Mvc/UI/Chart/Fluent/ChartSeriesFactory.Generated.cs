using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartSeries<T>>
    /// </summary>
    public partial class ChartSeriesFactory<T> where T : class
    {

        /// <summary>
        /// Defines area series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Area(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "area",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines area series bound to model member(s).
        /// </summary>
        /// <param name="expression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Area<TValue>(
            Expression<Func<T, TValue>> expression)
        {
            if (typeof(T).IsPlainType() && (!expression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "area",
                Field = expression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines area series bound to model member(s).
        /// </summary>
        /// <param name="expression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Area<TValue, TCategory>(
            Expression<Func<T, TValue>> expression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!expression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "area",
                Field = expression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound area series.
        /// </summary>
        /// <param name="memberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> Area(
            string memberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "area",
                Name = memberName.AsTitle(),
                Field = memberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bar series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Bar(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bar",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bar series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Bar<TValue>(
            Expression<Func<T, TValue>> valueExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bar",
                Field = valueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bar series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Bar<TValue, TCategory>(
            Expression<Func<T, TValue>> valueExpression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bar",
                Field = valueExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound bar series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> Bar(
            string valueMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bar",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines boxPlot series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> BoxPlot(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "boxPlot",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines boxPlot series bound to model member(s).
        /// </summary>
        /// <param name="lowerExpression">
        /// The expression used to extract the The lower value. from the model.
        /// </param>
        /// <param name="q1Expression">
        /// The expression used to extract the The Q1 value. from the model.
        /// </param>
        /// <param name="medianExpression">
        /// The expression used to extract the The median value. from the model.
        /// </param>
        /// <param name="q3Expression">
        /// The expression used to extract the The Q3 value. from the model.
        /// </param>
        /// <param name="upperExpression">
        /// The expression used to extract the The upper value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> BoxPlot<TValue>(
            Expression<Func<T, TValue>> lowerExpression,
            Expression<Func<T, TValue>> q1Expression,
            Expression<Func<T, TValue>> medianExpression,
            Expression<Func<T, TValue>> q3Expression,
            Expression<Func<T, TValue>> upperExpression)
        {
            if (typeof(T).IsPlainType() && (!lowerExpression.IsBindable() || !q1Expression.IsBindable() || !medianExpression.IsBindable() || !q3Expression.IsBindable() || !upperExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "boxPlot",
                LowerField = lowerExpression.MemberWithoutInstance(),
                Q1Field = q1Expression.MemberWithoutInstance(),
                MedianField = medianExpression.MemberWithoutInstance(),
                Q3Field = q3Expression.MemberWithoutInstance(),
                UpperField = upperExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines boxPlot series bound to model member(s).
        /// </summary>
        /// <param name="lowerExpression">
        /// The expression used to extract the The lower value. from the model.
        /// </param>
        /// <param name="q1Expression">
        /// The expression used to extract the The Q1 value. from the model.
        /// </param>
        /// <param name="medianExpression">
        /// The expression used to extract the The median value. from the model.
        /// </param>
        /// <param name="q3Expression">
        /// The expression used to extract the The Q3 value. from the model.
        /// </param>
        /// <param name="upperExpression">
        /// The expression used to extract the The upper value. from the model.
        /// </param>
        /// <param name="meanExpression">
        /// The expression used to extract the The mean value. from the model.
        /// </param>
        /// <param name="outliersExpression">
        /// The expression used to extract the The outliers value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> BoxPlot<TValue>(
            Expression<Func<T, TValue>> lowerExpression,
            Expression<Func<T, TValue>> q1Expression,
            Expression<Func<T, TValue>> medianExpression,
            Expression<Func<T, TValue>> q3Expression,
            Expression<Func<T, TValue>> upperExpression,
            Expression<Func<T, TValue>> meanExpression,
            Expression<Func<T, IList<TValue>>> outliersExpression)
        {
            if (typeof(T).IsPlainType() && (!lowerExpression.IsBindable() || !q1Expression.IsBindable() || !medianExpression.IsBindable() || !q3Expression.IsBindable() || !upperExpression.IsBindable() || !meanExpression.IsBindable() || !outliersExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "boxPlot",
                LowerField = lowerExpression.MemberWithoutInstance(),
                Q1Field = q1Expression.MemberWithoutInstance(),
                MedianField = medianExpression.MemberWithoutInstance(),
                Q3Field = q3Expression.MemberWithoutInstance(),
                UpperField = upperExpression.MemberWithoutInstance(),
                MeanField = meanExpression.MemberWithoutInstance(),
                OutliersField = outliersExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound boxPlot series.
        /// </summary>
        /// <param name="lowerMemberName">
        /// The name of the The lower value. member.
        /// </param>
        /// <param name="q1MemberName">
        /// The name of the The Q1 value. member.
        /// </param>
        /// <param name="medianMemberName">
        /// The name of the The median value. member.
        /// </param>
        /// <param name="q3MemberName">
        /// The name of the The Q3 value. member.
        /// </param>
        /// <param name="upperMemberName">
        /// The name of the The upper value. member.
        /// </param>
        /// <param name="meanMemberName">
        /// The name of the The mean value. member. Optional.
        /// </param>
        /// <param name="outliersMemberName">
        /// The name of the The outliers value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> BoxPlot(
            string lowerMemberName,
            string q1MemberName,
            string medianMemberName,
            string q3MemberName,
            string upperMemberName,
            string meanMemberName = null,
            string outliersMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "boxPlot",
                Name = lowerMemberName.AsTitle() + ", " + q1MemberName.AsTitle() + ", " + medianMemberName.AsTitle() + ", " + q3MemberName.AsTitle() + ", " + upperMemberName.AsTitle(),
                LowerField = lowerMemberName,
                Q1Field = q1MemberName,
                MedianField = medianMemberName,
                Q3Field = q3MemberName,
                UpperField = upperMemberName,
                MeanField = meanMemberName,
                OutliersField = outliersMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bubble series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Bubble(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bubble",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bubble series bound to model member(s).
        /// </summary>
        /// <param name="xValueExpression">
        /// The expression used to extract the The x value. from the model.
        /// </param>
        /// <param name="yValueExpression">
        /// The expression used to extract the The y value. from the model.
        /// </param>
        /// <param name="sizeExpression">
        /// The expression used to extract the The size value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Bubble<TXValue, TYValue, TSizeValue>(
            Expression<Func<T, TXValue>> xValueExpression,
            Expression<Func<T, TYValue>> yValueExpression,
            Expression<Func<T, TSizeValue>> sizeExpression)
        {
            if (typeof(T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable() || !sizeExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bubble",
                XField = xValueExpression.MemberWithoutInstance(),
                YField = yValueExpression.MemberWithoutInstance(),
                SizeField = sizeExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bubble series bound to model member(s).
        /// </summary>
        /// <param name="xValueExpression">
        /// The expression used to extract the The x value. from the model.
        /// </param>
        /// <param name="yValueExpression">
        /// The expression used to extract the The y value. from the model.
        /// </param>
        /// <param name="sizeExpression">
        /// The expression used to extract the The size value. from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the category from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Bubble<TXValue, TYValue, TSizeValue>(
            Expression<Func<T, TXValue>> xValueExpression,
            Expression<Func<T, TYValue>> yValueExpression,
            Expression<Func<T, TSizeValue>> sizeExpression,
            Expression<Func<T, string>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable() || !sizeExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bubble",
                XField = xValueExpression.MemberWithoutInstance(),
                YField = yValueExpression.MemberWithoutInstance(),
                SizeField = sizeExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound bubble series.
        /// </summary>
        /// <param name="xMemberName">
        /// The name of the The x value. member.
        /// </param>
        /// <param name="yMemberName">
        /// The name of the The y value. member.
        /// </param>
        /// <param name="sizeMemberName">
        /// The name of the The size value. member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the category member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> Bubble(
            string xMemberName,
            string yMemberName,
            string sizeMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bubble",
                Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
                XField = xMemberName,
                YField = yMemberName,
                SizeField = sizeMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bullet series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Bullet(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bullet",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bullet series bound to model member(s).
        /// </summary>
        /// <param name="currentExpression">
        /// The expression used to extract the The current value; from the model.
        /// </param>
        /// <param name="targetExpression">
        /// The expression used to extract the The target value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Bullet<TValue, TCategory>(
            Expression<Func<T, TValue>> currentExpression,
            Expression<Func<T, TCategory>> targetExpression)
        {
            if (typeof(T).IsPlainType() && (!currentExpression.IsBindable() || !targetExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bullet",
                CurrentField = currentExpression.MemberWithoutInstance(),
                TargetField = targetExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound bullet series.
        /// </summary>
        /// <param name="currentMemberName">
        /// The name of the The current value; member.
        /// </param>
        /// <param name="targetMemberName">
        /// The name of the The target value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> Bullet(
            string currentMemberName,
            string targetMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "bullet",
                Name = currentMemberName.AsTitle() + ", " + targetMemberName.AsTitle(),
                CurrentField = currentMemberName,
                TargetField = targetMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines candlestick series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Candlestick(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "candlestick",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines candlestick series bound to model member(s).
        /// </summary>
        /// <param name="openExpression">
        /// The expression used to extract the The open value. from the model.
        /// </param>
        /// <param name="highExpression">
        /// The expression used to extract the The high value. from the model.
        /// </param>
        /// <param name="lowExpression">
        /// The expression used to extract the The low value. from the model.
        /// </param>
        /// <param name="closeExpression">
        /// The expression used to extract the The close value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Candlestick<TValue>(
            Expression<Func<T, TValue>> openExpression,
            Expression<Func<T, TValue>> highExpression,
            Expression<Func<T, TValue>> lowExpression,
            Expression<Func<T, TValue>> closeExpression)
        {
            if (typeof(T).IsPlainType() && (!openExpression.IsBindable() || !highExpression.IsBindable() || !lowExpression.IsBindable() || !closeExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "candlestick",
                OpenField = openExpression.MemberWithoutInstance(),
                HighField = highExpression.MemberWithoutInstance(),
                LowField = lowExpression.MemberWithoutInstance(),
                CloseField = closeExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound candlestick series.
        /// </summary>
        /// <param name="openMemberName">
        /// The name of the The open value. member.
        /// </param>
        /// <param name="highMemberName">
        /// The name of the The high value. member.
        /// </param>
        /// <param name="lowMemberName">
        /// The name of the The low value. member.
        /// </param>
        /// <param name="closeMemberName">
        /// The name of the The close value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> Candlestick(
            string openMemberName,
            string highMemberName,
            string lowMemberName,
            string closeMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "candlestick",
                Name = openMemberName.AsTitle() + ", " + highMemberName.AsTitle() + ", " + lowMemberName.AsTitle() + ", " + closeMemberName.AsTitle(),
                OpenField = openMemberName,
                HighField = highMemberName,
                LowField = lowMemberName,
                CloseField = closeMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines column series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Column(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "column",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines column series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Column<TValue>(
            Expression<Func<T, TValue>> valueExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "column",
                Field = valueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines column series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Column<TValue, TCategory>(
            Expression<Func<T, TValue>> valueExpression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "column",
                Field = valueExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound column series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> Column(
            string valueMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "column",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines donut series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Donut(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "donut",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines donut series bound to model member(s).
        /// </summary>
        /// <param name="expressionValue">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Donut<TValue>(
            Expression<Func<T, TValue>> expressionValue,
            Expression<Func<T, string>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!expressionValue.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "donut",
                Field = expressionValue.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound donut series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> Donut(
            string valueMemberName,
            string categoryMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "donut",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines funnel series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Funnel(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "funnel",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines funnel series bound to model member(s).
        /// </summary>
        /// <param name="expressionValue">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Funnel<TValue>(
            Expression<Func<T, TValue>> expressionValue,
            Expression<Func<T, string>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!expressionValue.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "funnel",
                Field = expressionValue.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound funnel series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> Funnel(
            string valueMemberName,
            string categoryMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "funnel",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines horizontalWaterfall series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> HorizontalWaterfall(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "horizontalWaterfall",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines horizontalWaterfall series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> HorizontalWaterfall<TValue>(
            Expression<Func<T, TValue>> valueExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "horizontalWaterfall",
                Field = valueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines horizontalWaterfall series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> HorizontalWaterfall<TValue, TCategory>(
            Expression<Func<T, TValue>> valueExpression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "horizontalWaterfall",
                Field = valueExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound horizontalWaterfall series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> HorizontalWaterfall(
            string valueMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "horizontalWaterfall",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines line series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Line(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "line",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines line series bound to model member(s).
        /// </summary>
        /// <param name="expression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Line<TValue>(
            Expression<Func<T, TValue>> expression)
        {
            if (typeof(T).IsPlainType() && (!expression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "line",
                Field = expression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines line series bound to model member(s).
        /// </summary>
        /// <param name="expression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Line<TValue, TCategory>(
            Expression<Func<T, TValue>> expression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!expression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "line",
                Field = expression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound line series.
        /// </summary>
        /// <param name="memberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> Line(
            string memberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "line",
                Name = memberName.AsTitle(),
                Field = memberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines ohlc series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> OHLC(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "ohlc",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines ohlc series bound to model member(s).
        /// </summary>
        /// <param name="openExpression">
        /// The expression used to extract the The open value. from the model.
        /// </param>
        /// <param name="highExpression">
        /// The expression used to extract the The high value. from the model.
        /// </param>
        /// <param name="lowExpression">
        /// The expression used to extract the The low value. from the model.
        /// </param>
        /// <param name="closeExpression">
        /// The expression used to extract the The close value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> OHLC<TValue>(
            Expression<Func<T, TValue>> openExpression,
            Expression<Func<T, TValue>> highExpression,
            Expression<Func<T, TValue>> lowExpression,
            Expression<Func<T, TValue>> closeExpression)
        {
            if (typeof(T).IsPlainType() && (!openExpression.IsBindable() || !highExpression.IsBindable() || !lowExpression.IsBindable() || !closeExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "ohlc",
                OpenField = openExpression.MemberWithoutInstance(),
                HighField = highExpression.MemberWithoutInstance(),
                LowField = lowExpression.MemberWithoutInstance(),
                CloseField = closeExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound ohlc series.
        /// </summary>
        /// <param name="openMemberName">
        /// The name of the The open value. member.
        /// </param>
        /// <param name="highMemberName">
        /// The name of the The high value. member.
        /// </param>
        /// <param name="lowMemberName">
        /// The name of the The low value. member.
        /// </param>
        /// <param name="closeMemberName">
        /// The name of the The close value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> OHLC(
            string openMemberName,
            string highMemberName,
            string lowMemberName,
            string closeMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "ohlc",
                Name = openMemberName.AsTitle() + ", " + highMemberName.AsTitle() + ", " + lowMemberName.AsTitle() + ", " + closeMemberName.AsTitle(),
                OpenField = openMemberName,
                HighField = highMemberName,
                LowField = lowMemberName,
                CloseField = closeMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines pie series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Pie(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "pie",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines pie series bound to model member(s).
        /// </summary>
        /// <param name="expressionValue">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Pie<TValue>(
            Expression<Func<T, TValue>> expressionValue,
            Expression<Func<T, string>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!expressionValue.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "pie",
                Field = expressionValue.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound pie series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> Pie(
            string valueMemberName,
            string categoryMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "pie",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines polarArea series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> PolarArea(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "polarArea",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines polarArea series bound to model member(s).
        /// </summary>
        /// <param name="xValueExpression">
        /// The expression used to extract the The x value. from the model.
        /// </param>
        /// <param name="yValueExpression">
        /// The expression used to extract the The y value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> PolarArea<TXValue, TYValue>(
            Expression<Func<T, TXValue>> xValueExpression,
            Expression<Func<T, TYValue>> yValueExpression)
        {
            if (typeof(T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "polarArea",
                XField = xValueExpression.MemberWithoutInstance(),
                YField = yValueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound polarArea series.
        /// </summary>
        /// <param name="xMemberName">
        /// The name of the The x value. member.
        /// </param>
        /// <param name="yMemberName">
        /// The name of the The y value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> PolarArea(
            string xMemberName,
            string yMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "polarArea",
                Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
                XField = xMemberName,
                YField = yMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines polarLine series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> PolarLine(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "polarLine",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines polarLine series bound to model member(s).
        /// </summary>
        /// <param name="xValueExpression">
        /// The expression used to extract the The x value. from the model.
        /// </param>
        /// <param name="yValueExpression">
        /// The expression used to extract the The y value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> PolarLine<TXValue, TYValue>(
            Expression<Func<T, TXValue>> xValueExpression,
            Expression<Func<T, TYValue>> yValueExpression)
        {
            if (typeof(T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "polarLine",
                XField = xValueExpression.MemberWithoutInstance(),
                YField = yValueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound polarLine series.
        /// </summary>
        /// <param name="xMemberName">
        /// The name of the The x value. member.
        /// </param>
        /// <param name="yMemberName">
        /// The name of the The y value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> PolarLine(
            string xMemberName,
            string yMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "polarLine",
                Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
                XField = xMemberName,
                YField = yMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines polarScatter series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> PolarScatter(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "polarScatter",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines polarScatter series bound to model member(s).
        /// </summary>
        /// <param name="xValueExpression">
        /// The expression used to extract the The x value. from the model.
        /// </param>
        /// <param name="yValueExpression">
        /// The expression used to extract the The y value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> PolarScatter<TXValue, TYValue>(
            Expression<Func<T, TXValue>> xValueExpression,
            Expression<Func<T, TYValue>> yValueExpression)
        {
            if (typeof(T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "polarScatter",
                XField = xValueExpression.MemberWithoutInstance(),
                YField = yValueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound polarScatter series.
        /// </summary>
        /// <param name="xMemberName">
        /// The name of the The x value. member.
        /// </param>
        /// <param name="yMemberName">
        /// The name of the The y value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> PolarScatter(
            string xMemberName,
            string yMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "polarScatter",
                Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
                XField = xMemberName,
                YField = yMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines radarArea series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarArea(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarArea",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines radarArea series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarArea<TValue>(
            Expression<Func<T, TValue>> valueExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarArea",
                Field = valueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines radarArea series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarArea<TValue, TCategory>(
            Expression<Func<T, TValue>> valueExpression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarArea",
                Field = valueExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound radarArea series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarArea(
            string valueMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarArea",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines radarColumn series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarColumn(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarColumn",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines radarColumn series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarColumn<TValue>(
            Expression<Func<T, TValue>> valueExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarColumn",
                Field = valueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines radarColumn series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarColumn<TValue, TCategory>(
            Expression<Func<T, TValue>> valueExpression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarColumn",
                Field = valueExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound radarColumn series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarColumn(
            string valueMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarColumn",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines radarLine series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarLine(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarLine",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines radarLine series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarLine<TValue>(
            Expression<Func<T, TValue>> valueExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarLine",
                Field = valueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines radarLine series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarLine<TValue, TCategory>(
            Expression<Func<T, TValue>> valueExpression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarLine",
                Field = valueExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound radarLine series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> RadarLine(
            string valueMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "radarLine",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines rangeBar series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> RangeBar(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "rangeBar",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines rangeBar series bound to model member(s).
        /// </summary>
        /// <param name="fromExpression">
        /// The expression used to extract the The from value. from the model.
        /// </param>
        /// <param name="toExpression">
        /// The expression used to extract the The to value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RangeBar<TValue>(
            Expression<Func<T, TValue>> fromExpression,
            Expression<Func<T, TValue>> toExpression)
        {
            if (typeof(T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "rangeBar",
                FromField = fromExpression.MemberWithoutInstance(),
                ToField = toExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines rangeBar series bound to model member(s).
        /// </summary>
        /// <param name="fromExpression">
        /// The expression used to extract the The from value. from the model.
        /// </param>
        /// <param name="toExpression">
        /// The expression used to extract the The to value. from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RangeBar<TValue, TCategory>(
            Expression<Func<T, TValue>> fromExpression,
            Expression<Func<T, TValue>> toExpression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "rangeBar",
                FromField = fromExpression.MemberWithoutInstance(),
                ToField = toExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound rangeBar series.
        /// </summary>
        /// <param name="fromMemberName">
        /// The name of the The from value. member.
        /// </param>
        /// <param name="toMemberName">
        /// The name of the The to value. member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> RangeBar(
            string fromMemberName,
            string toMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "rangeBar",
                Name = fromMemberName.AsTitle() + ", " + toMemberName.AsTitle(),
                FromField = fromMemberName,
                ToField = toMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines rangeColumn series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> RangeColumn(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "rangeColumn",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines rangeColumn series bound to model member(s).
        /// </summary>
        /// <param name="fromExpression">
        /// The expression used to extract the The from value. from the model.
        /// </param>
        /// <param name="toExpression">
        /// The expression used to extract the The to value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RangeColumn<TValue>(
            Expression<Func<T, TValue>> fromExpression,
            Expression<Func<T, TValue>> toExpression)
        {
            if (typeof(T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "rangeColumn",
                FromField = fromExpression.MemberWithoutInstance(),
                ToField = toExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines rangeColumn series bound to model member(s).
        /// </summary>
        /// <param name="fromExpression">
        /// The expression used to extract the The from value. from the model.
        /// </param>
        /// <param name="toExpression">
        /// The expression used to extract the The to value. from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> RangeColumn<TValue, TCategory>(
            Expression<Func<T, TValue>> fromExpression,
            Expression<Func<T, TValue>> toExpression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!fromExpression.IsBindable() || !toExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "rangeColumn",
                FromField = fromExpression.MemberWithoutInstance(),
                ToField = toExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound rangeColumn series.
        /// </summary>
        /// <param name="fromMemberName">
        /// The name of the The from value. member.
        /// </param>
        /// <param name="toMemberName">
        /// The name of the The to value. member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> RangeColumn(
            string fromMemberName,
            string toMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "rangeColumn",
                Name = fromMemberName.AsTitle() + ", " + toMemberName.AsTitle(),
                FromField = fromMemberName,
                ToField = toMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines scatter series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Scatter(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "scatter",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines scatter series bound to model member(s).
        /// </summary>
        /// <param name="xValueExpression">
        /// The expression used to extract the The x value. from the model.
        /// </param>
        /// <param name="yValueExpression">
        /// The expression used to extract the The y value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Scatter<TXValue, TYValue>(
            Expression<Func<T, TXValue>> xValueExpression,
            Expression<Func<T, TYValue>> yValueExpression)
        {
            if (typeof(T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "scatter",
                XField = xValueExpression.MemberWithoutInstance(),
                YField = yValueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound scatter series.
        /// </summary>
        /// <param name="xMemberName">
        /// The name of the The x value. member.
        /// </param>
        /// <param name="yMemberName">
        /// The name of the The y value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> Scatter(
            string xMemberName,
            string yMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "scatter",
                Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
                XField = xMemberName,
                YField = yMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines scatterLine series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> ScatterLine(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "scatterLine",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines scatterLine series bound to model member(s).
        /// </summary>
        /// <param name="xValueExpression">
        /// The expression used to extract the The x value. from the model.
        /// </param>
        /// <param name="yValueExpression">
        /// The expression used to extract the The y value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> ScatterLine<TXValue, TYValue>(
            Expression<Func<T, TXValue>> xValueExpression,
            Expression<Func<T, TYValue>> yValueExpression)
        {
            if (typeof(T).IsPlainType() && (!xValueExpression.IsBindable() || !yValueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "scatterLine",
                XField = xValueExpression.MemberWithoutInstance(),
                YField = yValueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound scatterLine series.
        /// </summary>
        /// <param name="xMemberName">
        /// The name of the The x value. member.
        /// </param>
        /// <param name="yMemberName">
        /// The name of the The y value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> ScatterLine(
            string xMemberName,
            string yMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "scatterLine",
                Name = xMemberName.AsTitle() + ", " + yMemberName.AsTitle(),
                XField = xMemberName,
                YField = yMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalArea series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalArea(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalArea",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalArea series bound to model member(s).
        /// </summary>
        /// <param name="expression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalArea<TValue>(
            Expression<Func<T, TValue>> expression)
        {
            if (typeof(T).IsPlainType() && (!expression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalArea",
                Field = expression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalArea series bound to model member(s).
        /// </summary>
        /// <param name="expression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalArea<TValue, TCategory>(
            Expression<Func<T, TValue>> expression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!expression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalArea",
                Field = expression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound verticalArea series.
        /// </summary>
        /// <param name="memberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalArea(
            string memberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalArea",
                Name = memberName.AsTitle(),
                Field = memberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalBoxPlot series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalBoxPlot(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalBoxPlot",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalBoxPlot series bound to model member(s).
        /// </summary>
        /// <param name="lowerExpression">
        /// The expression used to extract the The lower value. from the model.
        /// </param>
        /// <param name="q1Expression">
        /// The expression used to extract the The Q1 value. from the model.
        /// </param>
        /// <param name="medianExpression">
        /// The expression used to extract the The median value. from the model.
        /// </param>
        /// <param name="q3Expression">
        /// The expression used to extract the The Q3 value. from the model.
        /// </param>
        /// <param name="upperExpression">
        /// The expression used to extract the The upper value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalBoxPlot<TValue>(
            Expression<Func<T, TValue>> lowerExpression,
            Expression<Func<T, TValue>> q1Expression,
            Expression<Func<T, TValue>> medianExpression,
            Expression<Func<T, TValue>> q3Expression,
            Expression<Func<T, TValue>> upperExpression)
        {
            if (typeof(T).IsPlainType() && (!lowerExpression.IsBindable() || !q1Expression.IsBindable() || !medianExpression.IsBindable() || !q3Expression.IsBindable() || !upperExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalBoxPlot",
                LowerField = lowerExpression.MemberWithoutInstance(),
                Q1Field = q1Expression.MemberWithoutInstance(),
                MedianField = medianExpression.MemberWithoutInstance(),
                Q3Field = q3Expression.MemberWithoutInstance(),
                UpperField = upperExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalBoxPlot series bound to model member(s).
        /// </summary>
        /// <param name="lowerExpression">
        /// The expression used to extract the The lower value. from the model.
        /// </param>
        /// <param name="q1Expression">
        /// The expression used to extract the The Q1 value. from the model.
        /// </param>
        /// <param name="medianExpression">
        /// The expression used to extract the The median value. from the model.
        /// </param>
        /// <param name="q3Expression">
        /// The expression used to extract the The Q3 value. from the model.
        /// </param>
        /// <param name="upperExpression">
        /// The expression used to extract the The upper value. from the model.
        /// </param>
        /// <param name="meanExpression">
        /// The expression used to extract the The mean value. from the model.
        /// </param>
        /// <param name="outliersExpression">
        /// The expression used to extract the The outliers value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalBoxPlot<TValue>(
            Expression<Func<T, TValue>> lowerExpression,
            Expression<Func<T, TValue>> q1Expression,
            Expression<Func<T, TValue>> medianExpression,
            Expression<Func<T, TValue>> q3Expression,
            Expression<Func<T, TValue>> upperExpression,
            Expression<Func<T, TValue>> meanExpression,
            Expression<Func<T, IList<TValue>>> outliersExpression)
        {
            if (typeof(T).IsPlainType() && (!lowerExpression.IsBindable() || !q1Expression.IsBindable() || !medianExpression.IsBindable() || !q3Expression.IsBindable() || !upperExpression.IsBindable() || !meanExpression.IsBindable() || !outliersExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalBoxPlot",
                LowerField = lowerExpression.MemberWithoutInstance(),
                Q1Field = q1Expression.MemberWithoutInstance(),
                MedianField = medianExpression.MemberWithoutInstance(),
                Q3Field = q3Expression.MemberWithoutInstance(),
                UpperField = upperExpression.MemberWithoutInstance(),
                MeanField = meanExpression.MemberWithoutInstance(),
                OutliersField = outliersExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound verticalBoxPlot series.
        /// </summary>
        /// <param name="lowerMemberName">
        /// The name of the The lower value. member.
        /// </param>
        /// <param name="q1MemberName">
        /// The name of the The Q1 value. member.
        /// </param>
        /// <param name="medianMemberName">
        /// The name of the The median value. member.
        /// </param>
        /// <param name="q3MemberName">
        /// The name of the The Q3 value. member.
        /// </param>
        /// <param name="upperMemberName">
        /// The name of the The upper value. member.
        /// </param>
        /// <param name="meanMemberName">
        /// The name of the The mean value. member. Optional.
        /// </param>
        /// <param name="outliersMemberName">
        /// The name of the The outliers value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalBoxPlot(
            string lowerMemberName,
            string q1MemberName,
            string medianMemberName,
            string q3MemberName,
            string upperMemberName,
            string meanMemberName = null,
            string outliersMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalBoxPlot",
                Name = lowerMemberName.AsTitle() + ", " + q1MemberName.AsTitle() + ", " + medianMemberName.AsTitle() + ", " + q3MemberName.AsTitle() + ", " + upperMemberName.AsTitle(),
                LowerField = lowerMemberName,
                Q1Field = q1MemberName,
                MedianField = medianMemberName,
                Q3Field = q3MemberName,
                UpperField = upperMemberName,
                MeanField = meanMemberName,
                OutliersField = outliersMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalBullet series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalBullet(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalBullet",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalBullet series bound to model member(s).
        /// </summary>
        /// <param name="currentExpression">
        /// The expression used to extract the The current value; from the model.
        /// </param>
        /// <param name="targetExpression">
        /// The expression used to extract the The target value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalBullet<TValue, TCategory>(
            Expression<Func<T, TValue>> currentExpression,
            Expression<Func<T, TCategory>> targetExpression)
        {
            if (typeof(T).IsPlainType() && (!currentExpression.IsBindable() || !targetExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalBullet",
                CurrentField = currentExpression.MemberWithoutInstance(),
                TargetField = targetExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound verticalBullet series.
        /// </summary>
        /// <param name="currentMemberName">
        /// The name of the The current value; member.
        /// </param>
        /// <param name="targetMemberName">
        /// The name of the The target value. member.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalBullet(
            string currentMemberName,
            string targetMemberName)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalBullet",
                Name = currentMemberName.AsTitle() + ", " + targetMemberName.AsTitle(),
                CurrentField = currentMemberName,
                TargetField = targetMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalLine series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalLine(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalLine",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalLine series bound to model member(s).
        /// </summary>
        /// <param name="expression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalLine<TValue>(
            Expression<Func<T, TValue>> expression)
        {
            if (typeof(T).IsPlainType() && (!expression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalLine",
                Field = expression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines verticalLine series bound to model member(s).
        /// </summary>
        /// <param name="expression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalLine<TValue, TCategory>(
            Expression<Func<T, TValue>> expression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!expression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalLine",
                Field = expression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound verticalLine series.
        /// </summary>
        /// <param name="memberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> VerticalLine(
            string memberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "verticalLine",
                Name = memberName.AsTitle(),
                Field = memberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines waterfall series bound to inline data.
        /// </summary>
        /// <param name="data">
        /// The list of data items to bind to
        /// </param>
        public virtual ChartSeriesBuilder<T> Waterfall(IEnumerable data)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "waterfall",
                Data = data
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines waterfall series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Waterfall<TValue>(
            Expression<Func<T, TValue>> valueExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "waterfall",
                Field = valueExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines waterfall series bound to model member(s).
        /// </summary>
        /// <param name="valueExpression">
        /// The expression used to extract the value from the model.
        /// </param>
        /// <param name="categoryExpression">
        /// The expression used to extract the The category value. from the model.
        /// </param>
        public virtual ChartSeriesBuilder<T> Waterfall<TValue, TCategory>(
            Expression<Func<T, TValue>> valueExpression,
            Expression<Func<T, TCategory>> categoryExpression)
        {
            if (typeof(T).IsPlainType() && (!valueExpression.IsBindable() || !categoryExpression.IsBindable()))
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "waterfall",
                Field = valueExpression.MemberWithoutInstance(),
                CategoryField = categoryExpression.MemberWithoutInstance()
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

        /// <summary>
        /// Defines bound waterfall series.
        /// </summary>
        /// <param name="valueMemberName">
        /// The name of the value member.
        /// </param>
        /// <param name="categoryMemberName">
        /// The name of the The category value. member. Optional.
        /// </param>
        public virtual ChartSeriesBuilder<T> Waterfall(
            string valueMemberName,
            string categoryMemberName = null)
        {
            var item = new ChartSeries<T>()
            {
                Chart = Chart,
                Type = "waterfall",
                Name = valueMemberName.AsTitle(),
                Field = valueMemberName,
                CategoryField = categoryMemberName
            };

            Container.Add(item);

            return new ChartSeriesBuilder<T>(item);
        }

    }
}
