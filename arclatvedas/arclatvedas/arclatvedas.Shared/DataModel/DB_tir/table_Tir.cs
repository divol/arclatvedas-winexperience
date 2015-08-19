using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using SQLite;
using Windows.Foundation;

public class Tir

{
    [PrimaryKey]
    public int Id { get; set; }
    public string location { get; set; }
    public string date { get; set; }
    public string distance { get; set; }
    public string comment { get; set; }
    public int blasonType { get; set; }
    public List<Score> scores; // 


}
