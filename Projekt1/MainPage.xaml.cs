using System.Transactions;
using Microsoft.Maui.Controls.StyleSheets;

namespace Projekt1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Dictionary<string, int> counters = new Dictionary<string, int>();
        public MainPage()
        {
            InitializeComponent();
        }
        private void AddCounter(string counterName)
        {
                counters[counterName] = 0;
            if (CounterNameEntry.Text == null || CounterNameEntry.Text == String.Empty)
                return;
                Label counterLabel = new Label
                {
                    Text = $"{CounterNameEntry.Text.ToString()}: 0",
                    TextColor = Colors.White,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = 40
                };
                Button plusButton = new Button { Text = "+" };
                Button minusButton = new Button
                {
                    Text = "-",
                    Margin = 10
                };


                plusButton.Clicked += (object sender, EventArgs e) =>
                {
                    counters[counterName]++;
                    counterLabel.Text = $"{CounterNameEntry.Text.ToString()}: {counters[counterName]}";
                };

                minusButton.Clicked += (object sender, EventArgs e) =>
                {
                    counters[counterName]--;
                    counterLabel.Text = $"{CounterNameEntry.Text.ToString()}: {counters[counterName]}";
                };
                CountersContainer.Children.Add(counterLabel);
                CountersContainer.Children.Add(plusButton);
                CountersContainer.Children.Add(minusButton);
            
        }

        private void OnAddCounterClicked(object sender, EventArgs e)
        {
            string newCounterName = "Counter" + (counters.Count + 1).ToString();
            AddCounter(newCounterName);
        }

    }

}
