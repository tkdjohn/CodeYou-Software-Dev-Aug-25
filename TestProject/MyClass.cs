using System.Data.Common;

public class Person
{
    public Person(int id, string name)
    { 
      Id = id ; 
      Name = name ;
    }
    public Person()
    {
        Id = -1;
        Name = "no name provided" ;
    }

    public int Id { get; set;}
    public string Name { get; set;}


    public (int, string) myMethod ()
    {
        return (1, "");
    }

    public void example ()
    {
        (int id, string name) = myMethod();
    }
}

public class MultipleItems
{
    public int Id { get; set;}
    public string Name { get; set;}
}