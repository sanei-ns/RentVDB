using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RentVDB.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        private string _email;

        [Required]
        [Display(Name = "Courrier électronique")]
        public string Email
        {
            get => _email;
            set => _email = value;
        }
    }

    public class ExternalLoginListViewModel
    {
        private string _returnUrl;

        public string ReturnUrl
        {
            get => _returnUrl;
            set => _returnUrl = value;
        }
    }

    public class SendCodeViewModel
    {
        private string _selectedProvider;
        private ICollection<SelectListItem> _providers;
        private string _returnUrl;
        private bool _rememberMe;

        public string SelectedProvider
        {
            get => _selectedProvider;
            set => _selectedProvider = value;
        }

        public ICollection<System.Web.Mvc.SelectListItem> Providers
        {
            get => _providers;
            set => _providers = value;
        }

        public string ReturnUrl
        {
            get => _returnUrl;
            set => _returnUrl = value;
        }

        public bool RememberMe
        {
            get => _rememberMe;
            set => _rememberMe = value;
        }
    }

    public class VerifyCodeViewModel
    {
        private string _provider;
        private string _code;
        private string _returnUrl;
        private bool _rememberBrowser;
        private bool _rememberMe;

        [Required]
        public string Provider
        {
            get => _provider;
            set => _provider = value;
        }

        [Required]
        [Display(Name = "Code")]
        public string Code
        {
            get => _code;
            set => _code = value;
        }

        public string ReturnUrl
        {
            get => _returnUrl;
            set => _returnUrl = value;
        }

        [Display(Name = "Mémoriser ce navigateur ?")]
        public bool RememberBrowser
        {
            get => _rememberBrowser;
            set => _rememberBrowser = value;
        }

        public bool RememberMe
        {
            get => _rememberMe;
            set => _rememberMe = value;
        }
    }

    public class ForgotViewModel
    {
        private string _email;

        [Required]
        [Display(Name = "Courrier électronique")]
        public string Email
        {
            get => _email;
            set => _email = value;
        }
    }

    public class LoginViewModel
    {
        private string _email;
        private string _password;
        private bool _rememberMe;

        [Required]
        [Display(Name = "Courrier électronique")]
        [EmailAddress]
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        [Display(Name = "Mémoriser le mot de passe ?")]
        public bool RememberMe
        {
            get => _rememberMe;
            set => _rememberMe = value;
        }
    }

    public class RegisterViewModel
    {
        private string _email;
        private string _password;
        private string _confirmPassword;

        [Required]
        [EmailAddress]
        [Display(Name = "Courrier électronique")]
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        [Required]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe ")]
        [System.ComponentModel.DataAnnotations.Compare("Password",
            ErrorMessage = "Le mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set => _confirmPassword = value;
        }
    }

    public class ResetPasswordViewModel
    {
        private string _email;
        private string _password;
        private string _confirmPassword;
        private string _code;

        [Required]
        [EmailAddress]
        [Display(Name = "Courrier électronique")]
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        [Required]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe")]
        [System.ComponentModel.DataAnnotations.Compare("Password",
            ErrorMessage = "Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set => _confirmPassword = value;
        }

        public string Code
        {
            get => _code;
            set => _code = value;
        }
    }

    public class ForgotPasswordViewModel
    {
        private string _email;

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email
        {
            get => _email;
            set => _email = value;
        }
    }
}
