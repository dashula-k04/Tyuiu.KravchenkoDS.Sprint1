
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KravchenkoDS.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2) 
            { return false; }
            char firstLetter = value[0];
            int index = value.IndexOf(firstLetter, 1);

            return index != -1;
        }
    }
}
