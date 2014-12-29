using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.Prism.StoreApps;

namespace CallistoCustomDialog.ViewModels
{
    class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            Person = new Person();

            ShowPopupClickedCommand = new RelayCommand(OnShowPopupClicked);
            SaveClickedCommand = new RelayCommand(OnSaveClicked);
            DialogBackClickedCommand = new RelayCommand(OnDialogBackClicked);
            CancelClickedCommand = new RelayCommand(OnCancelClicked);
        }

        private Person _person;
        public Person Person
        {
            get { return _person; }
            set { SetProperty(ref _person, value); }
        }

        // popup is bound to another item, to simplify 'Cancel' -> no need to undo changes in properties
        private Person _popupPerson;
        public Person PopupPerson
        {
            get { return _popupPerson; }
            set { SetProperty(ref _popupPerson, value); }
        }

        private bool _isOpen;
        public bool IsOpen
        {
            get { return _isOpen; }
            set { SetProperty(ref _isOpen, value); }
        }

        public RelayCommand ShowPopupClickedCommand { get; set; }
        public RelayCommand SaveClickedCommand { get; set; }
        public RelayCommand DialogBackClickedCommand { get; set; }
        public RelayCommand CancelClickedCommand { get; set; }

        private void OnShowPopupClicked()
        {
            PopupPerson = new Person();
            IsOpen = true;
        }

        private void OnSaveClicked()
        {
            // do your thing
            Person.Firstname = PopupPerson.Firstname;
            Person.Lastname = PopupPerson.Lastname;
            PopupPerson.Age = PopupPerson.Age;
            IsOpen = false;
        }

        private void OnDialogBackClicked()
        {
            // ignore, IsOpen is updated through 2 way binding
        }

        private void OnCancelClicked()
        {
            // ignore data and close
            IsOpen = false;
        }
    }
}
