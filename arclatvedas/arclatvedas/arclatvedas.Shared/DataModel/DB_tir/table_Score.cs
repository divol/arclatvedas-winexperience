using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using SQLite.Net.Attributes;
using Windows.Foundation;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions;
using Newtonsoft;

public class Score

{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [ForeignKey(typeof(Tir))]
    public int idScore { get; set; }

    [TextBlob("vBlobbed")]
    public List<int> v { get; set; }

    [TextBlob("haussesBlobbed")]
    public List<Point> hausses { get; set; }

    [TextBlob("zonesBlobbed")]
    public List<Point> zones { get; set; }


    public string vBlobbed { get; set; } //serialized version
    public string haussesBlobbed { get; set; } //serialized version
    public string zonesBlobbed { get; set; } //serialized version

    [ManyToOne]
    public Tir tir { get; set; }
}
