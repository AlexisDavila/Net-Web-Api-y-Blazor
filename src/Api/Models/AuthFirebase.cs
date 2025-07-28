
using System.Text.Json.Serialization;

namespace NetFirebase.Api.Models;

// Modelo para la respuesta de autenticación de Firebase
// Utiliza JsonPropertyName para mapear las propiedades a los nombres esperados por Firebase
public class AuthFirebase
{
   [JsonPropertyName("Kind")]
   public string? Kind { get; set; }
   [JsonPropertyName("LocalId")]
   public string? LocalId { get; set; }
   [JsonPropertyName("Email")]
   public string? Email { get; set; }
   [JsonPropertyName("DisplayName")]
   public string? DisplayName { get; set; }
   [JsonPropertyName("IdToken")]
   public string? IdToken { get; set; }
   [JsonPropertyName("Registered")]
   public bool Registered { get; set; }
   [JsonPropertyName("RefreshToken")]
   public string? RefreshToken { get; set; }
   [JsonPropertyName("ExpiresIn")]
   public long? ExpiresIn { get; set; }

}