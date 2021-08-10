using System.Collections.Generic;
using System.Reflection;

namespace AlinSpace.Builder
{
    public class TypeAnalysis<T>
    {
        public IEnumerable<ConstructorInfo> Constructors { get; set; }

        public IEnumerable<PropertyInfo> Properties { get; set; }

        public TypeAnalysis()
        {
            Constructors = typeof(T).GetConstructors();
            Properties = typeof(T).GetProperties();
        }
    }
}
