namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    using System;
    using FormControls.TreeView;

    public class Packages
    {
        public Guid Id { get; set; }

        //public Hierarchy<Package> Hierarchy { get; set; }

        //public void Load()
        //{
        //    this.Hierarchy = new Hierarchy<Package> { Id = Guid.NewGuid(), Enabled = true, Name = "Packages" };
        //    Hierarchy<Package> child = new Hierarchy<Package> { Id = Guid.NewGuid(), Enabled = true, Name = "Data" };
        //    this.Hierarchy.Children.Add(child);
        //    child.Children.Add(new Hierarchy<Package> { Id = Guid.NewGuid(), Enabled = true, Name = "Entity FrameWork (EF)" });
        //    child.Children.Add(new Hierarchy<Package> { Id = Guid.NewGuid(), Enabled = true, Name = "Mongo" });
        //    child = child.Children[0];

        //    Package package = new Package { Id = Guid.NewGuid(), Name = "Entity Framework (Repository)" };
        //    child.Children.Add(new Hierarchy<Package> { Id = Guid.NewGuid(), Enabled = true, Name = "Entity FrameWork 6(Simple)", Item = package });
        //    child.Children.Add(new Hierarchy<Package> { Id = Guid.NewGuid(), Enabled = true, Name = "Entity FrameWork 6(Repository)" });
        //    child.Children.Add(new Hierarchy<Package> { Id = Guid.NewGuid(), Enabled = true, Name = "Entity FrameWork 6(Domain Driven)" });
        //}

        public Packages()
        {
            
        }
    }
}
