using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlinSpace.Builder
{
    class CodeGenerator<T>
    {
        private readonly TypeAnalysis<T> typeAnalysis = new TypeAnalysis<T>();

        public StringBuilder Code { get; } = new StringBuilder();

        public CodeGenerator AddConstructor()
        {
            Code.Append($"\t\t public {typeof(T)}Build({typeof(T)} @object = null)\n");
            Code.Append($"\n");
            Code.Append($"\t\t {{");

            foreach(var property in )

            Code.Append($"\t\t\t {typeAnalysis.}");

        }

        public CodeGenerator AddProperty(PropertyInfo propertyInfo)
        {
            Code.Append($"\t\t public {propertyInfo.PropertyType} {propertyInfo.Name} {{ get; set; }}");
            return this;
        }

    }
}
