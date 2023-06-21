﻿using NeoServer.Web.API.Helpers;

namespace NeoServer.Web.API.IoC.Modules;

public static class AutoMapperInjection
{
    public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
    {
        var scanAssemblies = AssemblyHelper.Instance().GetAllAssemblies();

        var profiles = scanAssemblies
           .SelectMany(o => o.DefinedTypes
               .Where(x => x.IsClass)
               .Where(c => c.FullName.EndsWith("Profile"))
           );

        foreach (var profile in profiles)
            services.AddAutoMapper(profile);

        return services;
    }
}
