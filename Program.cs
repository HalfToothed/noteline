using Note;
using System.Text.Json;

namespace NoteLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NoteLine >");
            string content =  Console.ReadLine();

            NoteContent note = new NoteContent();

            note.Content = content;
            note.TimeStamp = DateTime.Now;
            
       

            string filePath = "/home/fibonacci/Desktop/Git/noteline/content.json";
            try{
                
                string jsonData = JsonSerializer.Serialize(note);
                Console.WriteLine(jsonData);
            File.WriteAllText(filePath, jsonData);

            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

    }

}