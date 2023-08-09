using SoundsGame.lib.Interfaces;
namespace SoundsGame.lib;

public class SoundsGameService : ISoundsGameService
{
    int _sequenceLength = 1;

    List<SequenceElement> Csequence = new List<SequenceElement>();

    private SequenceElement GetRandomElement()
    {
        Array values = Enum.GetValues(typeof(SequenceElement));
        var values_typed = new List<SequenceElement>(values.Cast<SequenceElement>());
        Random random = new Random();
        SequenceElement randomSequenceElement = values_typed[random.Next(values_typed.Count)];
        return randomSequenceElement;
    }


    /// <summary>
    /// gives the number to the player
    /// </summary>
    /// <returns></returns>
    public IEnumerable<SequenceElement> GenerateSequence()
    {
        for (int x = 0; x < _sequenceLength; x++)
        {
            SequenceElement newElement = GetRandomElement();
            Csequence.Add(newElement);
        }
        _sequenceLength = _sequenceLength + 1;
        return Csequence;
    }

    public bool GiveAnswer(IEnumerable<SequenceElement> Psequence)
    {
        if (Psequence == Csequence)
        {
            return true;
        }
        return false;
    }

    public void StartGame()
    {
        _sequenceLength = 1;
    }


}

