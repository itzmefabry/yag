/*
 * Created by SharpDevelop.
 * User: Fabry UwU
 * Date: 04/12/2025
 * Time: 08:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace prueba
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			multiplicacion m = new multiplicacion();
			m.Show();
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			resta res = new resta();
			res.Show();
			this.Hide();
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			suma sum = new suma();
			sum.Show();
			this.Hide();
		}
	}
}
