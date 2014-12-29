using Microsoft.Practices.Prism.StoreApps;

namespace CallistoCustomDialog.ViewModels
{
    internal class Person : BindableBase
    {
        private string _firstname;
        public string Firstname
        {
            get { return _firstname; }
            set { SetProperty(ref _firstname, value); }
        }

        private string _lastname;
        public string Lastname
        {
            get { return _lastname; }
            set { SetProperty(ref _lastname, value); }
        }

        private string _age;
        public string Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }
    }
}
