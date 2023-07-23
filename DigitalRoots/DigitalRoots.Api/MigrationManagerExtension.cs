using DigitalRoots.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DigitalRoots.Api;

public static class MigrationManager
{
    public static WebApplication MigrateDatabase(this WebApplication webApp)
    {
        using IServiceScope scope = webApp.Services.CreateScope();
        using ApplicationDbContext appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        try
        {
            appContext.Database.Migrate();
        }
        catch (Exception e)
        {
            //Log errors or do anything you think it's needed
            throw e;
        }
        return webApp;
    }
}