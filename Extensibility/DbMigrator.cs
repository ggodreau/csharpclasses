using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        // constructor
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("migration started at: " +  DateTime.Now);
            // function to migrate the database goes here
            _logger.LogInfo("migration finished at: " +  DateTime.Now);
        }
    }
}