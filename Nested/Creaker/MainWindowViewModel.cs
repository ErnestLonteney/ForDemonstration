using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows;

namespace Creaker.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {
       private string firstNumber = string.Empty;
       private string secondNumber = string.Empty;
       private string thirdNumber = string.Empty;
       private string fourthNumber = string.Empty;
       private string fifthNumber = string.Empty;
       private bool isGenerated = false;
       private ulong number = 0;


        public bool IsGenerated 
        { 
          get => isGenerated;
          set
          {
              SetProperty(ref isGenerated, value);
          }
        }

        public string FirstNumber
       {
            get => firstNumber; 
            set 
            {
                SetProperty(ref firstNumber, value);
            }
       }

        public string SecondNumber
        {
            get => secondNumber;
            set
            {
                SetProperty(ref secondNumber, value);
            }
        }

        public string ThirdNumber
        {
            get => thirdNumber;
            set
            {
                SetProperty(ref thirdNumber, value);
            }
        }

        public string FourthNumber
        {
            get => fourthNumber;
            set
            {
                SetProperty(ref fourthNumber, value);
            }
        }

        public string FivthNumber
        {
            get => fifthNumber;
            set
            {
                SetProperty(ref fifthNumber, value);
            }
        }

        public IRelayCommand GenerateCommand { get; }
        public IRelayCommand HaveAGoCommand { get; }

        public MainWindowViewModel()
        {
            GenerateCommand = new AsyncRelayCommand(GenerateCommandExecute);
            HaveAGoCommand = new RelayCommand(HaveAGoCommandExecute);
        }     
        

        private void HaveAGoCommandExecute()
        {
            var randomizer = new Random();
            uint counter = 0;
            ulong gusse = 0;
            bool f = false, s = false, t = false, fu = false;
            string
                   first = string.Empty,
                   second = string.Empty,
                   third = string.Empty,
                   fourth = string.Empty;

            do
            {
                counter++;

                if (!f)
                {
                    first = randomizer.Next(1, 9).ToString();
                    if (first != FirstNumber)
                        continue;
                    else
                        f = true;
                }

                if (!s)
                {
                    second = randomizer.Next(1, 9).ToString();
                    if (second != SecondNumber)
                        continue;
                    else
                        s = true;
                }

                if (!t)
                {
                    third = randomizer.Next(1, 9).ToString();
                    if (third != ThirdNumber)
                        continue;
                    else
                        t = true;
                }

                if (!fu)
                {
                    fourth = randomizer.Next(1, 9).ToString();
                    if (fourth != FourthNumber)
                        continue;
                    else
                        fu = true;
                }

                string fifth = randomizer.Next(1, 9).ToString();

                gusse = Convert.ToUInt64(first + second + third + fourth + fifth);
                // gusse = (ulong)randomizer.NextInt64(11111, 99999);            
            }
            while (number != gusse);

            MessageBox.Show($"It`s a number {gusse} with {counter} times");
        }

        private async Task GenerateCommandExecute()
        {          
            var randomizer = new Random();

            IsGenerated = false;
            for (int i = 0; i < 10; i++)
            {

                FirstNumber = randomizer.Next(1, 9).ToString();
                await Task.Delay(100);

                SecondNumber = randomizer.Next(1, 9).ToString();
                await Task.Delay(100);

                ThirdNumber = randomizer.Next(1, 9).ToString();
                await Task.Delay(100);

                FourthNumber = randomizer.Next(1, 9).ToString();
                await Task.Delay(100);

                FivthNumber = randomizer.Next(1, 9).ToString();
                await Task.Delay(100);
            }
            IsGenerated = true;

            number = Convert.ToUInt64(FirstNumber + SecondNumber + ThirdNumber + FourthNumber + FivthNumber);
        }

        
    }
}
