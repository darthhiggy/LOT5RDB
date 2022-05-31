using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LOT5RDB.Equipment.Server.ExtensionMethods;

public static class StartUpExtensionMethods
{
    public static IServiceCollection InjectEquipmentHandlers(this IServiceCollection serviceCollection) => serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());
}
