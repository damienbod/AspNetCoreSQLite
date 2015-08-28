1. Add to the commands in the project.json file   "ef": "EntityFramework.Commands"
2. In the command line where the bin is:          >dnx . ef migration add testMigration

NOTE: An Entity Id needs to be a string or GUID at present