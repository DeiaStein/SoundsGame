using System;
namespace SoundsGame.lib.Interfaces
{
	public interface ISoundsGameService
	{
		void StartGame();

		IEnumerable<SequenceElement> GenerateSequence();

		bool GiveAnswer(IEnumerable<SequenceElement> sequence);
	}
}

public enum SequenceElement
{
	One = 1,
	Two = 2,
	Three = 3,
}

