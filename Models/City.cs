namespace ToDo.Models
{
    public class City
    {
        int cityId;
      string cityName;
        public City(int cityId, string cityName)
        {
            this.cityId = cityId;
            this.cityName = cityName;
        }
        public int GetCityId()
        {
            return this.cityId;
        }
        public void SetCityId(int cityId)
        {
            this.cityId = cityId;
        }

        public string GetCityName()
        {
            return this.cityName;
        }
        public void SetCityName(string cityName)
        {
            this.cityName = cityName;
        }


    }
}
