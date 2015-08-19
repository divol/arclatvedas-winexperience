using System;
using SQLite;

public class table_Materiel
{
    [PrimaryKey]
    public int Id{ get; set; }
    public string name { get; set; }
    public string serialNumber { get; set; }
    public string dateAchat { get; set; }
    public string comment { get; set; }
    public string imagePath { get; set; }
    public table_Materiel()
	{
        
	}
}
