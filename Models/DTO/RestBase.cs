namespace NorthWind.API.Models.DTO
{
    public static class RestResponseType
    {
        public const string OK = "OK";
        public const string ERROR = "ERROR";
        public const string OTHER = "OTHER";
    }
    public class RestBase
    {
        public RestBase(string status)
        {
            this.status = status;
        }

        public virtual string status { get; set; }
    }
}