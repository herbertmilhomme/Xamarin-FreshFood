using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FreshFood.Custom.CustomBehaviors
{
    public class TextChangedBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty MinInputValueProperty = BindableProperty.Create(nameof(MinInputValue), typeof(int), typeof(TextChangedBehavior), defaultValue: 0);
        public static readonly BindableProperty MaxInputValueProperty = BindableProperty.Create(nameof(MaxInputValue), typeof(int), typeof(TextChangedBehavior), defaultValue: 20);

        public int MinInputValue
        {
            get { return (int)GetValue(MinInputValueProperty); }
            set { SetValue(MinInputValueProperty, value); }
        }
        public int MaxInputValue
        {
            get { return (int)GetValue(MaxInputValueProperty); }
            set { SetValue(MaxInputValueProperty, value); }
        }


        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += Entry_TextChanged;
            base.OnAttachedTo(entry);
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int len = ((Entry)sender).Text.Length;

                float percent = ((float)len - (float)MinInputValue) / ((float)MaxInputValue - (float)MinInputValue);
                double resultRed = Color.Red.R + percent * (Color.Green.R - Color.Red.R);
                double resultGreen = Color.Red.G + percent * (Color.Green.G - Color.Red.G);
                double resultBlue = Color.Red.B + percent * (Color.Green.B - Color.Red.B);
                ((Entry)sender).TextColor = new Color(resultRed, resultGreen, resultBlue);
            }
            catch (Exception)
            {

            }
        }


        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= Entry_TextChanged;
            base.OnDetachingFrom(entry);
        }
    }
}