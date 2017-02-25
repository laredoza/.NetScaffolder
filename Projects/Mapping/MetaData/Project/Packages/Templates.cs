namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    using System;

    using FormControls.TreeView;

    public class Templates
    {
        public Guid Id { get; set; }
        //public Hierarchy<Template> Hierarchy { get; set; }

        //public void Load()
        //{
        //    this.Hierarchy = new Hierarchy<Template> { Id = Guid.NewGuid(), Enabled = true, Name = "Templates" };
        //    this.Hierarchy.Children.Add(new Hierarchy<Template> { Id = Guid.NewGuid(), Enabled = true, Name = "Context" });
        //    Hierarchy<Template> child = new Hierarchy<Template> { Id = Guid.NewGuid(), Enabled = true, Name = "Entity" };
        //    this.Hierarchy.Children.Add(child);
        //    Template template = new Template { Id = Guid.NewGuid(), Name = "Entity Framework (EF)" };
        //    child.Children.Add(new Hierarchy<Template> { Id = Guid.NewGuid(), Enabled = true, Name = "Entity FrameWork (EF)", Item = template});
        //    this.Hierarchy.Children.Add(new Hierarchy<Template> { Id = Guid.NewGuid(), Enabled = true, Name = "Repository" });
        //}

        public Templates()
        {

        }
    }
}
