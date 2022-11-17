using GraphQL.Types;
using GrapthQL_Simple_Example.Models;

namespace GrapthQL_Simple_Example.GraphQL.GraphQLTypes
{
    public class StudentType : ObjectGraphType<student>
    {
        public StudentType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Marks);
        }
    }
}
