namespace Conversion
{
    public class Converter : Interfaces.IConverter
    {
        public string Convert(decimal number)
        {
            return number.ToString();
        }

    }
}