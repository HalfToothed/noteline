using System.Text.Json;
using Note;
using System.Linq;

namespace Data
{
    public class Factory
    {
        public static void Create()
        {
            string filePath = "Content.json";
            string existingData = File.ReadAllText(filePath);

            List<NoteContent> NoteList = new List<NoteContent>();

            if (existingData != "")
            {
                NoteList = JsonSerializer.Deserialize<List<NoteContent>>(existingData);
            }

            string content = Console.ReadLine();

            NoteContent note = new NoteContent();
            note.Content = content;
            note.TimeStamp = DateTime.Now;

            NoteList.Add(note);

            string jsonData = JsonSerializer.Serialize(NoteList);
            File.WriteAllText(filePath, jsonData);
        }

        public static void Read()
        {
            string filePath = "Content.json";
            string existingData = File.ReadAllText(filePath);

            if (existingData == "")
            {
                Console.WriteLine("No Notes Found");
            }
            else
            {
                List<NoteContent> existingNote = JsonSerializer.Deserialize<List<NoteContent>>(existingData);

                foreach (var note in existingNote)
                {
                    Console.WriteLine(
@$"Time : {note.TimeStamp} 
Content : {note.Content}");
                    Console.WriteLine();
                }
            }
        }

        public static void Delete()
        {
            string filePath = "Content.json";

            string jsonData = null;
            File.WriteAllText(filePath, jsonData);
        }

        public static void Del()
        {
            string filePath = "Content.json";
            string existingData = File.ReadAllText(filePath);


            List<NoteContent> existingNote = JsonSerializer.Deserialize<List<NoteContent>>(existingData);

            existingNote.RemoveAt(existingNote.Count() - 1);

            string jsonData = JsonSerializer.Serialize(existingNote);
            File.WriteAllText(filePath, jsonData);

        }
    }
}