using System;
namespace EFCORE.DOMAIN
{
	public class Team: BaseDomainModel
	{
		public int Id { get; set; }
		public string? Name { get; set; }
	}
}

