namespace WebApplication1.Models
{
	public static class Repository
	{
		private static List<Product> responses = new();
		public static IEnumerable<Product> Responses => responses;
		public static void AddResponse(Product response)
		{
			responses.Add(response);
		}
	}
}
