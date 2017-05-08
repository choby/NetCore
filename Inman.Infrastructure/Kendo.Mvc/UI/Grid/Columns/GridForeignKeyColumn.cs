namespace Kendo.Mvc.UI
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Linq.Expressions;
	using Kendo.Mvc.Extensions;
	using Kendo.Mvc.Infrastructure.Implementation.Expressions;
	using Microsoft.AspNetCore.Mvc.Rendering;

	public class GridForeignKeyColumn<TModel, TValue> : GridBoundColumn<TModel, TValue>, IGridForeignKeyColumn where TModel : class
    {        
        public GridForeignKeyColumn(Grid<TModel> grid, Expression<Func<TModel, TValue>> expression, SelectList data)
            : base(grid, expression)         
        {
            EditorTemplateName = "GridForeignKey";
            Data = data;
        }

        public SelectList Data
        {
            get;
            set;
        }

        protected override void Serialize(IDictionary<string, object> json)
        {
            base.Serialize(json);            

            json["values"] = Data.Select(i => new { text = i.Text, value = i.Value });            
        }
        
        protected override void AppendAdditionalViewData(IDictionary<string, object> viewData, object dataItem)
        {        
            object selectedValue;
            if (!Data.Any(i => i.Selected))
            {
                selectedValue = ((Expression<Func<TModel, TValue>>)System.Linq.Expressions.Expression.Lambda(typeof(Func<TModel, TValue>), ExpressionFactory.LiftMemberAccessToNull(Expression.Body), Expression.Parameters)).Compile().Invoke((TModel)dataItem);
            }
            else
            {
                selectedValue = Data.SelectedValue;
            }

            viewData[Member + "_Data"] = new SelectList(Data.Items, Data.DataValueField, Data.DataTextField, selectedValue);
        }
        
        public Action<IDictionary<string, object>, object> SerializeSelectList
        {
            get { return AppendAdditionalViewData; }
        }
    }
}
