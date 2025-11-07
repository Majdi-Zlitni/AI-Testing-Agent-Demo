using System.Text.Json.Serialization;

namespace AiTestAgent;

// Represents the overall request payload sent to the Azure AI endpoint.
public class AzureAiRequest
{
    [JsonPropertyName("input_data")]
    public RequestInputData InputData { get; set; }

    public AzureAiRequest(string prompt)
    {
        InputData = new RequestInputData(prompt);
    }
}

// Contains the actual prompt string.
public class RequestInputData
{
    [JsonPropertyName("input_string")]
    public List<string> InputString { get; set; }

    // Optional parameters to control the model's generation.
    [JsonPropertyName("parameters")]
    public Dictionary<string, object> Parameters { get; set; } =
        new()
        {
            { "temperature", 0.1 },
            { "top_p", 0.9 },
            { "do_sample", true },
            { "max_new_tokens", 2048 }
        };

    public RequestInputData(string prompt)
    {
        InputString = new List<string> { prompt };
    }
}

// Represents the structure of the response from the endpoint.
// The model's output is often a list of dictionaries or objects.
public class AzureAiResponse
{
    [JsonPropertyName("output")]
    public List<string> Output { get; set; } = new();
}
