using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LOT5RDB.Equipment.Shared.ExtensionMethods;

public static class StartUpExtensionMethods
{
    public static IServiceCollection InjectEquipmentRequest(this IServiceCollection serviceCollection) => serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());
}
