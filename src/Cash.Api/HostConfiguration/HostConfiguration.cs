﻿namespace Cash.Api.HostConfiguration;

public static partial class HostConfiguration
{
    public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
    {
        builder
            .AddIdentityInfrastructure()
            .AddCaching()
            .AddExposers();

        return new(builder);
    }
    public async static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
    {
        await app.SeedDataAsync();

        app.UseExposers();

        return app;
    }
}
