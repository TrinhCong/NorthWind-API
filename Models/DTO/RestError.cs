
namespace NorthWind.API.Models.DTO
{
    public class RestError : RestBase
    {
        public RestError()
            : base(RestResponseType.ERROR)
        {

        }

        public RestError(string status)
            : base(status)
        {
        }

        public RestErrorDetail[] errors { get; set; }
    }

    public class RestErrorDetail
    {
        public RestErrorDetail()
        {

        }

        public RestErrorDetail(int code)
            : this()
        {
            this.code = code;
        }

        public RestErrorDetail(int code, string message)
            : this(code)
        {
            this.message = message;
        }
        public RestErrorDetail(int code, string message, string type)
            : this(code, message)
        {
            this.type = type;
        }

        public int code { get; set; }
        public string message { get; set; }
        public string type { get; set; }
    }
}