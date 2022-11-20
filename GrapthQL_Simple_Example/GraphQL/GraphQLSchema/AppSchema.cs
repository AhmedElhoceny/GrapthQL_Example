using GraphQL.Types;
using GrapthQL_Simple_Example.GraphQL.GraphQLQueries;

namespace GrapthQL_Simple_Example.GraphQL.GraphQLSchema
{
    public class AppSchema:Schema
    {
        public AppSchema(IServiceProvider serviceProvider) : base(serviceProvider){
            Query = serviceProvider.GetRequiredService<AppQuery>();
            Mutation = serviceProvider.GetRequiredService<AppMutation>();
        }
    }
}
