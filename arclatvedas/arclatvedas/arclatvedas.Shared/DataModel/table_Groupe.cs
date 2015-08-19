using System;
using System.Collections.Generic;
using SQLite;

public class table_Groupe
{

    [PrimaryKey]
    public int Id { get; set; }
    public string name { get; set; }
    public List<table_Fleche> fleches;

}