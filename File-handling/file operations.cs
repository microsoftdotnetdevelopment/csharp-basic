using System;
using System.IO;

// FileStream class can read and write operating system files.
// public FileStream (string path, FileMode mode, bool ownsHandle);

// StreamWriter class can be used to write text files. 
FileStream fs = new FileStream(@"C:\Sample.txt", FileMode.OpenOrCreate, FileAccess.Write);
using (StreamWriter writer = new StreamWriter(fs))
{
	writer.Write("Sample Text ");
}

// StreamReader reads text files. 
FileStream fs1 = new FileStream(@"C:\Sample.txt", FileMode.OpenOrCreate, FileAccess.Read);
using (StreamReader reader = new StreamReader(fs1))
{
	//   textBox1.Text = reader.ReadToEnd();              
}




//create a file and write the data on file

class Pro
{
	static void Main(string[] args)
	{
		FileInfo finfo = new FileInfo("D:\\employee.txt");
		using (StreamWriter writer = finfo.CreateText())
		{
			writer.WriteLine("New File with various Text operations");
		}

		Console.Read();
	}
}

//Add text to the file 
class Pro1
{
	static void Main1(string[] args)
	{
		FileInfo finfo = new FileInfo("D:\\employee.txt");
		using (StreamWriter writer = finfo.AppendText())
		{
			writer.WriteLine("hlo bro");
		}

		Console.Read();
	}
}

//open the data which is stored in file
class Pro2
{
	static void Main2(string[] args)
	{
		FileInfo finfo = new FileInfo("D:\\employee.txt");
		using (StreamReader reader = finfo.OpenText())
		{
			Console.WriteLine(reader.ReadToEnd());
		}

		Console.Read();
	}
}

//read all data of file
class th
{
	public void accept()
	{
		string a = File.ReadAllText("d:\\employee.txt");
		Console.WriteLine(a);
	}
}
class abc
{
	static void Main(string[] arg)
	{
		th a = new th();
		a.accept();
	}
}

//create folder and find details of folder
class Program
{
	static void Main(string[] args)
	{
		Directory.CreateDirectory("D:\\New folder (2)\\NewDirectory");
		DirectoryInfo ob = new DirectoryInfo("D:\\New folder(2)\\NewDirectory");
		Console.WriteLine(ob.Parent);
		Console.WriteLine(ob.Root);
		Console.WriteLine(ob.Exists);
		Console.WriteLine(ob.FullName);
		Console.WriteLine(ob.CreationTime);
		Console.WriteLine(ob.LastAccessTime);
		Console.WriteLine(ob.LastWriteTime);
		Console.WriteLine(ob.Name);
		Console.WriteLine("NewDirectory is Created in d Directory");

	}
}
// o/p-
// New folder(2)
// D:\
// False
// D:\New folder(2)\NewDirectory
// 01-01-1601 05:30:00
// 01-01-1601 05:30:00
// 01-01-1601 05:30:00
// NewDirectory
// NewDirectory is Created in d Directory

//if directory is not created then create directory
class tes1t
{
	static void test()
	{
		if (!(Directory.Exists("e:\\check\\method")))
		{
			Directory.CreateDirectory("e:\\check\\method");
		}

		//input string(d:\employee.txt) from user then find details 
		string s = Console.ReadLine();
		DirectoryInfo ob = new DirectoryInfo(s);
		Console.WriteLine(ob.CreationTime);
		Console.WriteLine(ob.Exists);
		Console.WriteLine(ob.FullName);
		Console.WriteLine(ob.LastAccessTime);
		Console.WriteLine(ob.LastWriteTime);
		Console.WriteLine(ob.Name);
		Console.WriteLine(ob.Parent);
		Console.WriteLine(ob.Root);
	}
}
// o/p-
// d:\\employee.txt
// 12-02-2017 22:30:21
// False
// d:\employee.txt
// 12-02-2017 22:30:21
// 12-02-2017 22:30:21
// employee.txt

// d:\

//get all directories of path(d:\\)
class th1
{
	public void accept()
	{
		Console.WriteLine("Enter the path");
		string s = Console.ReadLine();
		display(s);
	}
	public void display(string s)
	{
		DirectoryInfo d = new DirectoryInfo(s);

		DirectoryInfo[] list = d.GetDirectories();
		details(list);
	}
	public void details(DirectoryInfo[] list)
	{
		foreach (var i in list)
		{
			Console.WriteLine(i.CreationTime);
			Console.WriteLine(i.Name);
		}
	}
	class abc
	{
		static void Main(string[] arg)
		{
			th1 a = new th1();
			a.accept();
		}
	}
}

//get details of partition
class Pro5
{
	static void Main5(string[] args)
	{
		DriveInfo[] di = DriveInfo.GetDrives();
		Console.WriteLine("Total Partitions");

		foreach (DriveInfo items in di)
		{
			Console.WriteLine(items.Name);
		}
	}
}
// o/p-
// Total Partitions
// C:\
// D:\
// E:\
// G:\

//get drive info-
class th4
{
	static void Main4(string[] args)
	{


		DriveInfo[] di = DriveInfo.GetDrives();

		Console.WriteLine("Total Partitions");
		Console.WriteLine("---------------------");
		foreach (DriveInfo items in di)
		{
			Console.WriteLine(items.Name);
		}
		Console.Write("\nEnter the Partition::");
		string ch = Console.ReadLine();

		DriveInfo dInfo = new DriveInfo(ch);

		Console.WriteLine("\n");

		Console.WriteLine("Drive Name::{0}", dInfo.Name);
		Console.WriteLine("Total Space::{0}", dInfo.TotalSize);
		Console.WriteLine("Free Space::{0}", dInfo.TotalFreeSpace);
		Console.WriteLine("Drive Format::{0}", dInfo.DriveFormat);
		Console.WriteLine("Volume Label::{0}", dInfo.VolumeLabel);
		Console.WriteLine("Drive Type::{0}", dInfo.DriveType);
		Console.WriteLine("Root dir::{0}", dInfo.RootDirectory);
		Console.WriteLine("Ready::{0}", dInfo.IsReady);

		Console.ReadKey();
	}
}