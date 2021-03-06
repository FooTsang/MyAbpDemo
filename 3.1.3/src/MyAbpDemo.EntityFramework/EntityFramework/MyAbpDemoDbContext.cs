﻿using System.Data.Common;
using Abp.EntityFramework;

namespace MyAbpDemo.EntityFramework
{
    public class MyAbpDemoDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MyAbpDemoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyAbpDemoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyAbpDemoDbContext since ABP automatically handles it.
         */
        public MyAbpDemoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MyAbpDemoDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MyAbpDemoDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
