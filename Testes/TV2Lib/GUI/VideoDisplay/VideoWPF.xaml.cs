//    Copyright (C) 2006-2007  Regis COSNIER
//
//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program; if not, write to the Free Software
//    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeTV
{
	/// <summary>
	/// Interaction logic for VideoWPF.xaml
	/// </summary>

	public partial class VideoWPF : System.Windows.Controls.UserControl
	{
		public VideoWPF()
		{
			InitializeComponent();

			//this.Resize += new System.EventHandler(this.videoControl_Resize);
			//this.DoubleClick += new System.EventHandler(this.videoControl_DoubleClick);
			//this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.videoControl_KeyDown);
			//this.MouseWheel += new MouseEventHandler(videoControl_MouseWheel);
		}

		public System.Windows.Controls.Image WPFImage { get { return this.ImageVideo; } }

		protected override void OnMouseWheel(MouseWheelEventArgs e)
		{
			base.OnMouseWheel(e);
		}
	}
}