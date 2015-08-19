using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

public class Fleche
{
    [PrimaryKey]
    public int Id { get; set; }
    public string modele { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public float grain { get; set; }
    public string spin { get; set; }
    public float diametreoutside { get; set; }
    public float taille { get; set; }
    public string fabricant { get; set; }


}

