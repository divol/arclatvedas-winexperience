using System;
using System.Collections.Generic;
using SQLite;

public class Groupe
{

    [PrimaryKey]
    public int Id { get; set; }
    public string name { get; set; }
    public List<Fleche> fleches;

}