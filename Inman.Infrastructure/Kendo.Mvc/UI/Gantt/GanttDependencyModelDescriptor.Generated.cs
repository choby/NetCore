namespace Kendo.Mvc.UI
{
    using Extensions;
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using System.Reflection;

    public class GanttDependencyModelDescriptor : ModelDescriptor
    {
        public GanttDependencyModelDescriptor(Type modelType, IModelMetadataProvider modelMetadataProvider)
            : base(modelType, modelMetadataProvider)
        {
        }

        public string PredecessorId { get; set; }
        public string SuccessorId { get; set; }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (Id != null)
            {
                json["id"] = Id.Name;
            }

            var fields = new Dictionary<string, object>();
            json["fields"] = fields;

            Fields.Each(prop =>
            {
                var field = new Dictionary<string, object>();

                var modelInterface = typeof (IGanttDependency);

                var currentMember = prop.Member;

                if (modelInterface.GetProperty(currentMember) != null)
                {
                    var updatedMember = Char.ToLowerInvariant(currentMember[0]) + currentMember.Substring(1);
                    fields[updatedMember] = field;
                    field["from"] = currentMember;
                }
                else if (PredecessorId.HasValue() && currentMember == PredecessorId)
                {
                    fields["predecessorId"] = field;
                    field["from"] = currentMember;
                }
                else if (SuccessorId.HasValue() && currentMember == SuccessorId)
                {
                    fields["successorId"] = field;
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

                field["type"] = prop.MemberType.ToJavaScriptType().ToLowerInvariant();

                if (prop.MemberType.IsNullableType() || prop.DefaultValue != null)
                {
                    field["defaultValue"] = prop.DefaultValue;
                }
            });
        }
    }
}
