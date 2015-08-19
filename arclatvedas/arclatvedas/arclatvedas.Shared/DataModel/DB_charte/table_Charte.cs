using System;
using System.Collections.Generic;
using SQLite;

public class Charte
{
    [PrimaryKey]
    public int Id { get; set; }
    public long length { get; set; }
    public long hight { get; set; }
    public long low { get; set; }

    public List<Groupe> groupes;

    public Charte()
    {

    }
}
