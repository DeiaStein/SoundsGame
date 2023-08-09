using SoundsGame.lib;

// See https://aka.ms/new-console-template for more information
SoundsGameService soundsGameService = new SoundsGameService();

soundsGameService.StartGame();
var sequence = soundsGameService.GenerateSequence();

PlaySequence(sequence);



void PlaySequence(IEnumerable<SequenceElement> sequence)
{
    foreach (var element in sequence)
    {
        Console.WriteLine("\a");
    }
}