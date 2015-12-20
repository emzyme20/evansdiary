using System;
using System.Collections.Generic;
using System.Dynamic;

namespace EvansDiary.Web.Diary.Extensions
{
    public static class ObjectExtensions
    {
        public static ExpandoObject ToExpando(this object staticObject)
        {
            IDictionary<string, object> expando = new ExpandoObject();
            var properties = staticObject.GetType().GetProperties();

            foreach (var property in properties)
            {
                expando.Add(new KeyValuePair<string, object>(property.Name, property.GetValue(staticObject, null)));
            }

            return (ExpandoObject) expando;
        }

        public static string ToStringWithDefault(this object objectToStringify, object defaultIfNull)
        {
            return objectToStringify == null
                ? (string) defaultIfNull
                : objectToStringify.ToString();
        }

        public static TTarget With<TTarget>(this TTarget objectToModify, params Action<TTarget>[] modifications)
        {
            foreach (var modification in modifications)
            {
                modification.Invoke(objectToModify);
            }

            return objectToModify;
        }
    }
}