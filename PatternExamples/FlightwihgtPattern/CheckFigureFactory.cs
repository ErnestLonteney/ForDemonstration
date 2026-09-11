namespace FlightwihgtPattern
{
    internal class CheckFigureFactory
    {
        private Dictionary<(string type, CheckColors color), Figure> _figures;

        public CheckFigureFactory()
        {
            _figures = new Dictionary<(string type, CheckColors color), Figure>();
        }

        public CheckFigure CreateFigure(string type, CheckColors color)
        {
            if (!_figures.ContainsKey((type, color)))
            {
                _figures[(type, color)] = new CheckFigure(type, color);
            }

            return _figures[(type, color)] == null ? 
                throw new Exception("Figure not found") :
                (CheckFigure)_figures[(type, color)];
        }
    }
}
