using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LOT5RDB.Skills.Server.ExtensionMethods;

public static class StartUpExtensionMethods
{
    public static IServiceCollection InjectSkillHandlers(this IServiceCollection serviceCollection) => serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());
}
