
using DatastructureAndAlgo_Practice;

ProgramHelpers helper = new ProgramHelpers();
IRunProgram program = helper.GetInstance();
if (program != null)
{
	program.Run();
	while (true)
	{
		Console.WriteLine("Do you want to continue? Press Y to continue.");
		if (!Console.ReadLine().Equals("y", StringComparison.CurrentCultureIgnoreCase))
		{
			break;
		}
		program.Run();

	}
}

