// Readonly is the keyword whose value we can change during runtime or we can assign it at run time but only through the non-static constructor
// const's are implicitly static
public class Const_V_Readonly
{
	public const int I_CONST_VALUE = 2;
	public readonly int I_RO_VALUE;
	public Const_V_Readonly()
	{
		I_RO_VALUE = 3;
	}

	static void Main()
	{

	}
}