using System;
using System.Collections.Generic;

class MainClass 
{
    public static void Main (string[] args) 
    {
        ReadRecord();
    }

    public static void ReadRecord()
    {
        var dadosEncontrados = ReadRecord ("1190", "dados.csv", 9);
        foreach(var itemEncontrado in dadosEncontrados) 
        {
            Console.WriteLine(string.Join(" ", itemEncontrado));
        }
        
        Console.ReadLine();
    }

    public static IEnumerable<string[]> ReadRecord(string searchTerm, string filepath, int positionOfSearchTerm)
    {
        positionOfSearchTerm--;

        string[] lines = System.IO.File.ReadAllLines(filepath);

        var retorno = new List<string[]>();
        for (int i = 0; i < lines.Length; i++)
        {
            string[] fields = lines[i].Split(',');
            if (recordMatches(searchTerm, fields, positionOfSearchTerm))
            {
                Console.WriteLine("Record found");
                retorno.Add(fields);
            }
        }

        return retorno;    
    }

    public static bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)
    {
        return record[positionOfSearchTerm].Equals(searchTerm);
    }
}