namespace DotNetScaffolder.Mapping.MetaData
{
    using System;
    using System.Collections.Generic;

    public class Hierarchy<T>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ParentId { get; set; }
        public bool Enabled { get; set; }
        public T Item { get; set; }

        public List<Hierarchy<T>> Children { get; set; }

        public Hierarchy()
        {
            this.Enabled = true;
            this.Children = new List<Hierarchy<T>>();
        }
    }
}
