using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

public class Distance

{
    [PrimaryKey]
    public int Id { get; set; }
    public string name { get; set; }
    public string unit { get; set; }
    public string comment { get; set; }
    public List<Hausse> hausses;

}
