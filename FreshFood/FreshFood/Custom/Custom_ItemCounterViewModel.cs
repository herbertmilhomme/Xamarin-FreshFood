using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FreshFood.Custom
{
    public class Custom_ItemCounterViewModel : BindableObject
    {
        public Custom_ItemCounterViewModel()
        {
            DecreaseCommand = new Command<object>(OnDecreaseButtonPressed);
            IncreaseCommand = new Command<object>(OnIncreaseButtonPressed);
        }
        private int MinValue = 0;
        private int MaxValue = 10;
        public ICommand DecreaseCommand { get; set; }
        public ICommand IncreaseCommand { get; set; }

        private int _quantity;
        public int Quantity
        {
            get 
            { 
                return _quantity; 
            }
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }

        }
        public void OnDecreaseButtonPressed(object view)
        {
            if (MinValue <= Quantity - 1)
            {
                AnimateButton((View)view);
                Quantity -= 1;
            }
        }
        public void OnIncreaseButtonPressed(object view)
        {
            if (Quantity + 1 <= MaxValue)
            {
                AnimateButton((View)view);
                Quantity += 1;
            }
        }

        private async Task AnimateButton(View view)
        {
            await view.ScaleTo(1.5, 50, Easing.Linear);
            await Task.Delay(100);
            await view.ScaleTo(1, 50, Easing.Linear);
        }
    }
}
