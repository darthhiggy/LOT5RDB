using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LOT5RDB.Skills.Shared.ExtensionMethods;

public static class StartUpExtensionMethods
{
    public static IServiceCollection InjectSkillRequest(this IServiceCollection serviceCollection) => serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());
}
