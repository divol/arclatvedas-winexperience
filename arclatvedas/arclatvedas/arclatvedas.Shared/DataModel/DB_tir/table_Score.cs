using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using SQLite;
using Windows.Foundation;

public class Score

{
    [PrimaryKey]
    public int Id { get; set; }
    public int idScore { get; set; }
    public List<int> v;
    public List<Point> hausses; // point en double
    public List<Point> zones; // point en double


}
