using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

public class Groupe
{

    [PrimaryKey,AutoIncrement]
    public int Id { get; set; }
    public string name { get; set; }

    [ManyToMany(typeof(CharteGroupe))]
    public List<Charte> chartes { get; set; }

    [ManyToMany(typeof(GroupeFleche))]
    public  List<Fleche> fleches { get; set; }


    public Groupe()
    {
    }
}