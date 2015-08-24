using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

public class Charte
{
    [ PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public long length { get; set; }
    public long hight { get; set; }
    public long low { get; set; }

    [ManyToMany(typeof(CharteGroupe))]
    public List<Groupe> groupes { get; set; }

   
}
