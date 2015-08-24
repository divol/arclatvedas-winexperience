using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

public class Distance

{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string name { get; set; }
    public string unit { get; set; }
    public string comment { get; set; }

    [OneToMany]
    public List<Hausse> hausses { get; set; }

}
