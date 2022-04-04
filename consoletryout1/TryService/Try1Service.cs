
namespace TryService
{
	public class Try1Service: ITry1Service
	{
		IRunService RunService { get; }

		public Try1Service(IRunService runService)
		{
			RunService = runService;
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
