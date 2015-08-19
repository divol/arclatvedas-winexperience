using System;
using SQLite;

public class table_Arrow
{
    [PrimaryKey]
    public int Id { get; set; }
    public string name { get; set; }
    public double length { get; set; }
    public int spin { get; set; }

    public string feather { get; set; }
    public string point { get; set; }
    public string dateAchat { get; set; }
    public string comment { get; set; }
    public table_Arrow()
    {

    }
}
