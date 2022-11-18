using GraphQL;
using GraphQL.Types;
using GrapthQL_Simple_Example.GraphQL.GraphQLTypes;

namespace GrapthQL_Simple_Example.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IStudentRepository studentRepository)
        {
            Field<ListGraphType<StudentType>>(
                "students",
                resolve : context => studentRepository.GetAllStudents()
                );
            Field<StudentType>(
                "student",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "Id" }),
                resolve:context =>
                {
                    var id = context.GetArgument<int>("Id");
                    return studentRepository.GetStudentDetails(id);
                });
        }
    }
}
