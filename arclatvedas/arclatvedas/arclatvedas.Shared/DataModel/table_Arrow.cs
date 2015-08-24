using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;


public class Arrow
{
    [PrimaryKey,AutoIncrement]
    public int Id { get; set; }
    public string name { get; set; }
    public double length { get; set; }
    public int spin { get; set; }

    public string feather { get; set; }
    public string point { get; set; }
    public string dateAchat { get; set; }
    public string comment { get; set; }
    public Arrow()
    {

    }
}
