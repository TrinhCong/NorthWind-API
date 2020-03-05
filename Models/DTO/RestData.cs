namespace NorthWind.API.Models.DTO
{
    public class RestData : RestBase
    {
        public RestData()
            : base(RestResponseType.OK)
        {
            
        }
        public RestData(string status)
            : base(status)
        {
        }

        public object data { get; set; }
    }
}