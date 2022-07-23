using System.ComponentModel.DataAnnotations;

namespace AuthenticationApi.Dtos;

public class LoginRequest
{
    [Required]
    public string? Username { get; set; }
    [Required]
    public string? Password { get; set; }
}
