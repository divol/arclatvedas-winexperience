using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

public class Tir

{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string location { get; set; }
    public string date { get; set; }
    public string distance { get; set; }
    public string comment { get; set; }
    public int blasonType { get; set; }

    [OneToMany]
    public List<Score> scores { get; set; }


}
