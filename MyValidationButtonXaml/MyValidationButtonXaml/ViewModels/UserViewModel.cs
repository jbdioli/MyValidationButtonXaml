using PropertyChanged;

namespace MyValidationButtonXaml.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class UserViewModel
    {
        public UserViewModel(bool isLastnameValid, bool isFirstnameValid)
        {
            IsLastnameValid = isLastnameValid;
            IsFirstnameValid = isFirstnameValid;
        }

        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public bool IsLastnameValid { get; set; }
        public bool IsFirstnameValid { get; set; }
    }
}