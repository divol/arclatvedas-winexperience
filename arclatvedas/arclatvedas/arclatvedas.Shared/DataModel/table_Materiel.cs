using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

public class Materiel
{
    [PrimaryKey,AutoIncrement]
    public int Id{ get; set; }
    public string name { get; set; }
    public string serialNumber { get; set; }
    public string dateAchat { get; set; }
    public string comment { get; set; }
    public string imagePath { get; set; }
    public Materiel()
	{
        
	}
}
