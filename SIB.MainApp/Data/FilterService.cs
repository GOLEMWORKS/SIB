﻿namespace SIB.MainApp.Data
{
	public class FilterService
	{
		List<Filter> Filters = new List<Filter>() {
			/* Здесь создаются объекты */
			new Filter(){FilterID = 1, TerminName="SIB",TerminNameT="СИБ", CreateDate=Convert.ToDateTime("03-Dec-2023")}
		};

		public async Task<List<Filter>> FilterList()
		{
			return await Task.FromResult(Filters);
		}
	}
}
