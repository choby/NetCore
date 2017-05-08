namespace Kendo.Mvc.UI
{
    using Extensions;
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class TreeListModelDescriptor : ModelDescriptor
    {
        public TreeListModelDescriptor(Type modelType, IModelMetadataProvider modelMetadataProvider)
            : base(modelType, modelMetadataProvider)
        { 
        }

        public string ParentId { get; set; }

        public object Expanded { get; set; }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (Id != null)
            {
                json["id"] = Id.Name;
            }

            var fields = new Dictionary<string, object>();
            json["fields"] = fields;

            if (Expanded is bool)
            {
                json["expanded"] = (bool)Expanded;
            }

            Fields.Each(prop =>
            {
                var field = new Dictionary<string, object>();

                var currentMember = prop.Member;

                if (ParentId.HasValue() && currentMember == ParentId)
                {
                    fields["parentId"] = field;
                    field["from"] = currentMember;
                }
                else if (currentMember == (Expanded as string))
                {
                    fields["expanded"] = field;
                    field["from"] = currentMember;
                }
                else
                {
                    fields[currentMember] = field;
                }

                if (!prop.IsEditable)
                {
                    field["editable"] = false;
                }

                field["nullable"] = prop.IsNullable;

                field["type"] = prop.MemberType.ToJavaScriptType().ToLowerInvariant();

                if (prop.MemberType.IsNullableType() || prop.DefaultValue != null || (!prop.IsNullable && prop.DefaultValue != null))
                {
                    field["defaultValue"] = prop.DefaultValue;
                }
            });
        }
    }
}
