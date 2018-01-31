using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Program
{   
    public void Main()
    {
        const string json = @"{
                              ""map"": [
                                [""S"", ""S"", ""S"", ""S""],
                                [""S"", ""S"", ""C"", ""S""],
                                [ ""S"", ""S"", ""S"", ""S"" ],
                                [""S"", ""null"", ""S"", ""S""]
                              ],
                              ""start"": {""X"": 3, ""Y"": 0, ""facing"": ""N""},
                              ""commands"": [ ""TL"",""A"",""C"",""A"",
                                              ""C"",""TR"",""A"",""C""],
                              ""battery"": 80
                            }";

        var items = JsonConvert.DeserializeObject<Inicial>(json);
        Console.WriteLine(items.battery);
    }
}


public class Inicial
{
    public IList<IList<string>> map { get; set; } // Mude aqui
    public Start start { get; set; }
    public IList<string> commands { get; set; }
    public string battery { get; set; }
}

public class Start
{
    public int X { get; set; }
    public int Y { get; set; }
    public string faccing { get; set; }
}
