using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfMahAppsNumericUpDown
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private double _numericUpDownValue;
        private double _textBoxValue;

        public MainWindowViewModel()
        {
            NumericUpDownValue = 5;
            TextBoxValue = 5;
        }

        public double NumericUpDownValue
        {
            get => _numericUpDownValue;
            set
            {
                if (Math.Abs(_numericUpDownValue - value) < double.Epsilon) return;
                _numericUpDownValue = value;
                OnPropertyChanged(nameof(NumericUpDownValue));
            }
        }
        public double TextBoxValue
        {
            get => _textBoxValue;
            set
            {
                if (Math.Abs(_textBoxValue - value) < double.Epsilon) return;
                _textBoxValue = value;
                OnPropertyChanged(nameof(TextBoxValue));
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
