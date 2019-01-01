using System;

namespace Whisp.Application.Enum
{
    public static class ResponseMessages
    {
        public const string Success = "Success";
        public const string Error = "The server is unable to process your request at the moment.";
        
        public const string InvalidParam = "The parameters specified is invalid or incomplete. Please refer to the API documentation for usage.";
        public const string RecordNotFound = "Record not found.";
    }
}
