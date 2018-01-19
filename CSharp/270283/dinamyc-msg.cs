void Main()
{
	string json = "{\"Nome\": \"Marconcilio\", \"Data\": \"21/01/18\"}";
	string template = "Olá [Nome], Tenha um bom dia ... hoje é [Data] e é seu aniversario";
			
	Console.WriteLine(template);
	Console.WriteLine(Transformar(template, json));
}

string Transformar(string template, string json)
{
	var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);	
	
	string nova = template;
	foreach(var par in dict)
	{
		nova = nova.Replace($"[{par.Key}]", par.Value);
	}
	
	return nova;
}