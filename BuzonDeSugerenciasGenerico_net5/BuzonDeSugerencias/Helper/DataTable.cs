using System.Collections.Generic;

namespace BuzonDeSugerencias.Helper
{
	public class DataTable
	{
		public int draw
		{
			get;
			set;
		}

		public int recordsTotal
		{
			get;
			set;
		}

		public int recordsFiltered
		{
			get;
			set;
		}

		public List<dynamic> data
		{
			get;
			set;
		}
	}
}
