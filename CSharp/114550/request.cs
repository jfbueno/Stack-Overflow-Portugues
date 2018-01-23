public class Program
{
	public static void Main()
	{
		var client = new RestClient
		{
			BaseUrl = new Uri("http://fipeapi.appspot.com/")
		};
		
		var req = new RestRequest("api/1/{tipo}/marcas.json", Method.GET);
		
		req.AddParameter("tipo", "carros", ParameterType.UrlSegment);
		
		var response = client.Execute(req);
		List<Marca> contentResponse = JsonConvert.DeserializeObject<List<Marca>>(response.Content);
		// ^ Nesta lista vão estar todas as marcas da resposta		
	}
}

public class Marca
{
	public int Id { get; set; }
	public string Key { get; set; }
	public string Name { get; set; }
	public string Fipe_Name { get; set; }
}