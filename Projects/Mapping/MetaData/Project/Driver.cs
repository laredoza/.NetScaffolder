namespace DotNetScaffolder.Mapping.MetaData.Project
{
    using System;
    using System.Collections.Generic;

    using global::MetaData;

    public class Driver
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DriverType DriverType { get; set; }

        public static List<Driver> Load(Guid driverId)
        {
            List<Driver> drivers = new List<Driver>();

            // Todo: Actually load this properly
            Driver driver = new Driver { Id = new Guid("338e435a-9de7-46d7-b4f0-e5ec6de44d0a"), Name = "Entity FrameWork 6" };
            driver.DriverType = new DriverType();
            driver.DriverType.Load(driver.Id);
            drivers.Add(driver);

            // Todo: Actually load this properly
            driver = new Driver { Id = new Guid("338e435a-9de7-46d7-b4f0-e5ec6de44d0b"), Name = "Mongo" };
            driver.DriverType = new DriverType();
            driver.DriverType.Load(driver.Id);
            driver.DriverType.Name = "Official Mongo Drivers";
            drivers.Add(driver);

            return drivers;
        }
    }
}
