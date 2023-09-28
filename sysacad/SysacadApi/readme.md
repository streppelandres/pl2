
# Create database: (TODO: Find a better way to do this)
- Execute the API once with the next code inside of `Program.cs`:
```csharp
            using (var scope = app.Services.CreateScope())
            {
                var dataContext = scope.ServiceProvider.GetRequiredService<SysacadContext>();
                dataContext.Database.Migrate();
            }
```
- In the package manager console execute: `Add-Migration MigrationName -OutputDir "Infrastructure/Persistence/Migrations"`

# Update database:
- Create a migration: `Add-Migration MigrationName -OutputDir "Infrastructure/Persistence/Migrations"`
- Apply the migration: `Update-Database -MigrationDirectory "Infrastructure/Persistence/Migrations"`