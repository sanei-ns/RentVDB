using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace RentVDB.Models
{
    public class IndexViewModel
    {
        private bool _hasPassword;
        private IList<UserLoginInfo> _logins;
        private string _phoneNumber;
        private bool _twoFactor;
        private bool _browserRemembered;

        public bool HasPassword
        {
            get => _hasPassword;
            set => _hasPassword = value;
        }

        public IList<UserLoginInfo> Logins
        {
            get => _logins;
            set => _logins = value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public bool TwoFactor
        {
            get => _twoFactor;
            set => _twoFactor = value;
        }

        public bool BrowserRemembered
        {
            get => _browserRemembered;
            set => _browserRemembered = value;
        }
    }

    public class ManageLoginsViewModel
    {
        private IList<UserLoginInfo> _currentLogins;
        private IList<AuthenticationDescription> _otherLogins;

        public IList<UserLoginInfo> CurrentLogins
        {
            get => _currentLogins;
            set => _currentLogins = value;
        }

        public IList<AuthenticationDescription> OtherLogins
        {
            get => _otherLogins;
            set => _otherLogins = value;
        }
    }

    public class FactorViewModel
    {
        private string _purpose;

        public string Purpose
        {
            get => _purpose;
            set => _purpose = value;
        }
    }

    public class SetPasswordViewModel
    {
        private string _newPassword;
        private string _confirmPassword;

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} doit compter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nouveau mot de passe")]
        public string NewPassword
        {
            get => _newPassword;
            set => _newPassword = value;
        }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le nouveau mot de passe")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword",
            ErrorMessage = "Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set => _confirmPassword = value;
        }
    }

    public class ChangePasswordViewModel
    {
        private string _oldPassword;
        private string _newPassword;
        private string _confirmPassword;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe actuel")]
        public string OldPassword
        {
            get => _oldPassword;
            set => _oldPassword = value;
        }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} doit compter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nouveau mot de passe")]
        public string NewPassword
        {
            get => _newPassword;
            set => _newPassword = value;
        }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le nouveau mot de passe")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword",
            ErrorMessage = "Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set => _confirmPassword = value;
        }
    }

    public class AddPhoneNumberViewModel
    {
        private string _number;

        [Required]
        [Phone]
        [Display(Name = "Numéro de téléphone")]
        public string Number
        {
            get => _number;
            set => _number = value;
        }
    }

    public class VerifyPhoneNumberViewModel
    {
        private string _code;
        private string _phoneNumber;

        [Required]
        [Display(Name = "Code")]
        public string Code
        {
            get => _code;
            set => _code = value;
        }

        [Required]
        [Phone]
        [Display(Name = "Numéro de téléphone")]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }
    }

    public class ConfigureTwoFactorViewModel
    {
        private string _selectedProvider;
        private ICollection<SelectListItem> _providers;

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
    }
}