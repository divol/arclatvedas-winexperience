using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

public class Fleche
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string modele { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public float grain { get; set; }
    public string spin { get; set; }
    public float diametreoutside { get; set; }
    public float taille { get; set; }
    public string fabricant { get; set; }

    [ManyToMany(typeof(GroupeFleche))]
    public List<Groupe> groupes { get; set; }
}

