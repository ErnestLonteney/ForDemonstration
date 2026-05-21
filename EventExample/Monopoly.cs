namespace EventExample
{
    class Monopoly
    {
        public bool IsEndOfGame { get; set; }
        public int CurrentPosition { get; private set; }
        public string CurretField => (CurrentPosition) switch
        {
            0 => "Go",
            10 => "Jail",
            20 => "Free Parking",
            30 => "Go to Jail",
            _ => $"Some property"
        };

        public event Action OnPassGo;
        public event Action OnGoToJail;

        public byte DiceValue { get; private set; }


        public void RollDice()
        {
            Random random = new Random();
            var dice1 = random.Next(1, 7);  
            var dice2 = random.Next(1, 7);
            
            DiceValue = (byte)(dice1 + dice2);

            CurrentPosition = CurrentPosition + DiceValue > 39 ? CurrentPosition + DiceValue - 40 : CurrentPosition + DiceValue;    
        }


        public string ProcessResult()
        {
            switch (CurrentPosition)
            {
                case 0:
                    OnPassGo?.Invoke();
                    return "You are on the Go field. Collect $200.";
                case 10:
                    return "You are on Jail. It`s just visiting!";
                case 20:
                    return "You are on Free Parking. Take a break and enjoy the view.";
                case 30:
                    OnGoToJail?.Invoke();
                    return "You are in Jail. Pay $50 or roll doubles to get out.";
               
            }

            return string.Empty;
        }


    }
}
