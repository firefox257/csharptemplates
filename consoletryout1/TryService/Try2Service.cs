
namespace TryService
{
	public class Try2Service: ITry1Service
	{
		IRunService RunService { get; }

		public Try2Service()
		{
			RunService = Factory<IRunService>.Get(); 
		}
		
		public bool RunThis(int i1)
		{
			RunService.RunMe();
			i1 = i1 % 3;
			if (i1 > 0) return true;
			return false;
		}
	}
}
