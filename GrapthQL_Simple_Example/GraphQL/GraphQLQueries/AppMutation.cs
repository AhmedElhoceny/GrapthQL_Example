using GraphQL;
using GraphQL.Types;
using GrapthQL_Simple_Example.GraphQL.GraphQLTypes;
using GrapthQL_Simple_Example.Models;

namespace GrapthQL_Simple_Example.GraphQL.GraphQLQueries
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(IStudentRepository studentRepository)
        {
            Field<StudentType>(
                "CreateStudent",
                arguments:new QueryArguments(new QueryArgument<NonNullGraphType<StudentInputType>> { Name = "student"}),
                resolve : context =>
                {
                    var studentObj = context.GetArgument<student>("student");
                    return studentRepository.AddStudent(studentObj);
                }
            );
        }
    }
}
