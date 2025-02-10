using System.ComponentModel.DataAnnotations;

public class RegisterAccountForm
{
    [Required(ErrorMessage = "User name is required!")]
    [StringLength(8, ErrorMessage = "Max 8 characters allowed!")]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required!")]
    [EmailAddress(ErrorMessage = "The email address is invalid")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password is required!")]
    [MinLength(8, ErrorMessage = "Password must be at least of length 8")]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password confirmation is required!")]
    [Compare("Password", ErrorMessage = "Passwords don't match")]
    public string ConfirmPassword { get; set; } = string.Empty;
}
