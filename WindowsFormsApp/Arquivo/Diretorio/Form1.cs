using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diretorio
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string path = @"c:\curso\";

			bool res = Directory.Exists(path + "guigas");
			//lista.Items.Add(res);

			//if (!res)
			//{
			//	Directory.CreateDirectory(path + "guigas");
			//}

			//if (res)
			//{
			//	Directory.Delete(path + "guigas");
			//}

			//if (res)
			//{
			//	Directory.Move(path + "guigas", path + @"destino\guigas");
			//}

			//string[] dirs = Directory.GetDirectories(path);

			//foreach (string d in dirs)
			//{
			//	lista.Items.Add(d);
			//}

			//string[] files = Directory.GetFiles(path);

			//foreach (string f in files)
			//{
			//	lista.Items.Add(f);
			//}

			//string root = Directory.GetDirectoryRoot(path);
			//lista.Items.Add(root);

			//string[] drives = Directory.GetLogicalDrives();
			//lista.Items.AddRange(drives);

			//DirectoryInfo info = Directory.GetParent(path);
			//lista.Items.Add(info.FullName);

			string dir = Directory.GetCurrentDirectory();
			lista.Items.Add(dir);
        }
	}
}
