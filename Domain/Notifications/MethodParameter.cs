using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PSPublicMessagingAPI.Domain.Notifications;

public record MethodParameter
{
    private MethodParameter()
    {
    }

    public string Parameter { get; init; }

    

   

    public static MethodParameter Create(string parameter)
    {
        try
        {
            return new MethodParameter
            {
                Parameter = JToken.Parse(parameter).ToString()
            };
        }
        catch (JsonReaderException ex)
        {
            
            throw ex;
        }

        
    }
    
};