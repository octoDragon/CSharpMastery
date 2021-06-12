using System;

public class Entity
{
    private string name;
    string Name
    {
        get { return name; }
        set { Name = value; }
    }
}

public class EntityEventArgs : EventArgs
{
    public Entity Entity {get; set;}
}