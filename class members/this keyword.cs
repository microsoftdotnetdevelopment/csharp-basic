// This Keyword-
// 1.this keyword is used for differentiating instance members from input parameters of a method. 
class Circle5
{
	int radius;

	public Circle5() { }

	public Circle5(int radius)
	{
		this.radius = radius;
	}

	static void Main()
	{

	}
}
// 2. this keyword is used to call one constructor from another constructor.  
class Circle2
{
	int radius;

	public Circle2() : this(5) { } //Default Constructor calls parameterized constructor

	public Circle2(int radius)
	{
		this.radius = radius;
	}
}
// 3-this keyword is used to pass current instance to other methods. 
class Shape
{
	public void drawCircle(Circle objCircle)
	{
		//this method accepts Circle object to draw it on the screen. 
	}
}
class Circle
{
	//...
	void paintShape()
	{
		Shape shape = new Shape();
		shape.drawCircle(this);
	}
}