using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

public class Hausse

{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string name { get; set; }
    public string hausse { get; set; }

    [ForeignKey(typeof(Distance))]
    public int DistanceId { get; set; }


    [ManyToOne]
    public Distance distance { get; set; }

}
