public class Scripture
{
    private Reference _reference;
    private string _fullText;

    public Scripture(Reference reference, string fullText)
    {
        _reference = reference;
        _fullText = fullText;
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n{_fullText}";
    }

    public bool IsCompletelyHidden(string[] words)
    {
        return !words.Any(w => !w.Contains("_"));
    }

    public string ReplaceWordsWithUnderscores(string[] words, int[] indices)
    {
        foreach (int index in indices)
        {
            string wordToErase = words[index];
            words[index] = new string('_', wordToErase.Length);
        }
        return string.Join(" ", words);
    }
}
