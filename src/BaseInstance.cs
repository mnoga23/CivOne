// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.


namespace CivOne
{
	public abstract class BaseInstance
	{
		protected static Game Game => Game.Instance;
		protected static Map Map => Map.Instance;
		protected static Player Human => Game.Instance.HumanPlayer;
		protected static IRuntime Runtime => RuntimeHandler.Runtime;
		protected static Settings Settings => Settings.Instance;

		protected static void Log(string text, params object[] parameters) => Runtime.Log(text, parameters);
	}
}