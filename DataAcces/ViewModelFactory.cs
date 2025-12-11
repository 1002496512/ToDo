using Microsoft.AspNetCore.Mvc.Formatters;
using System.Data;
using ToDo.Models;

namespace ToDo.DataAcces
{
    public class ViewModelFactory
    {

        ModelFactory modelFactory ;
        DbHelper dbHelper;
        public ViewModelFactory(DbHelper dbHelper)
        {
            this.modelFactory = new ModelFactory();
            this.dbHelper = dbHelper;   
        }
        public City[] GetCityes()
        {
            string sql = "Select CityId, CityName from Cities";
            DataTable dataTable = dbHelper.GetDataTable(sql, "Cities");
            City[] cityes = new City[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cityes[i] = modelFactory.GetCity(dataTable.Rows[i]);
            }
            dbHelper.CloseConnection();
            return cityes;
        }

        
    }
}
