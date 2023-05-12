//The responsibility of this class is to hold the journal that user had written. 
// Display the journal , save the file and load the file of journal.
public class Journal
{
    // There are two attribuites in this class: one is _filename: string and _journals: list.
    public List<Entry> _journals = new List<Entry>();
    public string _filename;

    // THe method is to display all the entries in journal.
    public void Displayj()
    {
        foreach (Entry entry in _journals )
        {
            entry.Display(); // Call the Display() of Entry
        }
        
    }

    // A method that saves the file with .txt and
    // separates the element in the line with "|".
    public void SaveFilej()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename , true))
        {
            foreach (Entry entry in _journals)
            {
                outputFile.WriteLine($"{entry._date}|{entry._weather}|{entry._prompt}|{entry._entry}");
            }
            
        }
        // Clear the list after saving to avoid duplicate storage.
        _journals.Clear();
    }
    //A method that loads file from cumputer.
    // Restore from txt to list.
    public List<Entry> LoadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._weather = parts[1];
            entry._prompt = parts[2];
            entry._entry = parts[3];
            _journals.Add(entry);
        }
        //Return a list to main program.
        return _journals;
    }

}