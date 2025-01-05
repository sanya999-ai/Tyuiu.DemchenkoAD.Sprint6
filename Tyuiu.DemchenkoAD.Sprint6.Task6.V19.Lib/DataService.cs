using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.DemchenkoAD.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] words = text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;

            foreach (string word in words)
            {
                if (word.Contains("l"))
                {
                    result += word + "";
                }
            }

            return result;
        }
    }

}
    

