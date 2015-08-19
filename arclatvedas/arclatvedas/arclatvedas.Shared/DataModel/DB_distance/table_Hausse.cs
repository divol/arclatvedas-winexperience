using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

public class Hausse

{
    [PrimaryKey]
    public int Id { get; set; }
    public int idDistance { get; set; }
    public string name { get; set; }
    public string hausse { get; set; }


}
