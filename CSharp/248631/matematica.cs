void Main()
{
    var input = new[] { "000001010" };
	var valores = input
                  .Select(l => (decimal)Convert.ToInt32(l) / 100)
                  .ToList();

	foreach(var val in valores)
		Console.WriteLine(val);	
}
