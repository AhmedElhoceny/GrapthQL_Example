using GraphQL.Types;

namespace GrapthQL_Simple_Example.GraphQL.GraphQLTypes
{
    public class StudentInputType : InputObjectGraphType
    {
        public StudentInputType()
        {
            Name = "StudentInput";
            Field<NonNullGraphType<StringGraphType>>("Name");
            Field<NonNullGraphType<IntGraphType>>("Marks");
        }
    }
}
