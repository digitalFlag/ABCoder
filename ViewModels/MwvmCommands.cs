using ABCoder.ViewModels.Base;
using System;
using System.Windows;
using System.Windows.Input;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {
        #region Close Application Command

        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #region Change Selection Of Combo Box Mode Command

        public ICommand ChangeSelectionOfComboBoxModeCommand { get; }

        private bool CanChangeSelectionOfComboBoxModeCommandExecute(object p) => true;

        private void OnChangeSelectionOfComboBoxModeCommandExecuted(object p)
        {
            ButtonActionContent = ComboBoxModeSelectedIndex switch
            {
                0 => ComboBoxModeCodeContent,
                1 => ComboBoxModeDecodeContent,
                _=> throw new Exception("You enterd the wrong index."),
            };
            OnPropertyChanged();
        }

        #endregion

        #region Execute Button Command

        public ICommand ExecuteButtonCommand { get; }

        private bool CanExecuteButtonCommandExecute(object p) => true;

        private void OnExecuteButtonCommandExecuted(object p)
        {






            OnPropertyChanged();
        }

        #endregion

    }
}
