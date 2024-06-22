using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System
{
    public static class Extensions
    {
        /// <summary>
        ///  Basically gives you the variable, parameter, property (member) name.
        ///  
        /// I.e:
        /// 
        /// var testStringVariable = "foo";
        /// string nameOfTestVariable = MemberInfoGetting.GetMemberName(() => testStringVariable); // == "testStringVariable"
        /// 
        /// </summary>
        public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }

        /// <summary>
        /// Enum extension - Get attribute of an enum (when attribute added)
        /// </summary>
        public static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return attributes.Length > 0
              ? (T)attributes[0]
              : null;
        }


        /// <summary>
        /// Get properties of an object
        /// </summary>
        public static PropertyInfo[] GetProperties(this object obj)
        {
            return obj.GetType()
                      .GetProperties();
        }

        /// <summary>
        /// Get properties of an object
        /// </summary>
        public static PropertyInfo GetProperty(this object obj, string propertyName)
        {
            return obj.GetType()
                      .GetProperties()
                      .FirstOrDefault(p => p.Name == propertyName);
        }

        /// <summary>
        /// Get properties value of an object
        /// </summary>
        public static object GetPropertyValue(this object obj, string propertyName, out Type type)
        {
            type = typeof(object);

            var value = obj.GetType()
                           .GetProperties()
                           .FirstOrDefault(p => p.Name == propertyName)
                           .GetValue(obj);

            type = value.GetType();

            return value;
        }

        /// <summary>
        /// Enum extension - Get attribute 'Description' of an enum (when attribute 'tag' added)
        /// </summary>
        public static string Description(this Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }

        /// <summary>
        /// Get attribute 'Description' of an object (when attribute 'tag' added)
        /// </summary>
        public static string Description(this PropertyInfo property)
        {
            var attribute = property.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                    .FirstOrDefault() as DescriptionAttribute;

            return attribute?.Description;
        }

        /// <summary>
        /// Get attribute 'Description' of an object (when attribute 'tag' added)
        /// </summary>
        public static string Description(this object obj, string propertyName)
        {
            var descriptionAttribute = obj.GetType()
                                          .GetProperty(propertyName)?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                          .FirstOrDefault() as DescriptionAttribute;

            string descriptionValue = descriptionAttribute?.Description;

            return descriptionValue;
        }
    }
}
