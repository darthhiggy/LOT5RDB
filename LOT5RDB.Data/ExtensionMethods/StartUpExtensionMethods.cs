using LOT5RDB.Data.Repositories.EquipmentRepos;
using LOT5RDB.Data.Repositories.SkillRepos;
using LOT5RDB.Equipment.Shared.ItemQualities.Interfaces;
using LOT5RDB.Equipment.Shared.Weapons.Interfaces;
using LOT5RDB.Skills.Shared.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LOT5RDB.Data.ExtensionMethods;

public static class StartUpExtensionMethods
{
    public static IServiceCollection InjectRepos(this IServiceCollection services)
    {
        // equipment
        services.AddScoped<IWeaponsRepository, WeaponRepository>();
        services.AddScoped<IItemQualitiesRepository, ItemQualitiesRepository>();
        
        // skills
        services.AddScoped<ISkillRepository, SkillRepository>();
        services.AddScoped<ISkillGroupRepository, SkillGroupRepository>();

        return services;
    }
}
