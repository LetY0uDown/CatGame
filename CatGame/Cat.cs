namespace CatGame
{
    public class Cat
    {
        public Cat(string name)
        {
            Name = name;

            Hungry = 100;
            Mood = 100;
            Sleep = 100;
        }

        private sbyte _hungry;
        private sbyte _mood;
        private sbyte _sleep;
        public string Name { get; }
        public sbyte Hungry
        {
            get => _hungry;
            set
            {
                _hungry = value;

                if (value < 0)
                    _hungry = 0;
                if (value > 100)
                    _hungry = 100;
            }
        }
        public sbyte Mood
        {
            get => _mood;
            set
            {
                _mood = value;

                if (value < 0)
                    _mood = 0;
                if (value > 100)
                    _mood = 100;
            }
        }
        public sbyte Sleep
        {
            get => _sleep;
            set
            {
                _sleep = value;

                if (value < 0)
                    _sleep = 0;
                if (value > 100)
                    _sleep = 100;
            }
        }
    }
}
