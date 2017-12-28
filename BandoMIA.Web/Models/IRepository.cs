using System.Collections.Generic;

namespace BandoMIA.Web.Models
{
	public interface IRepository
	{
		IEnumerable<City> Cities { get; }

		void AddCity(City newCity);
	}
}