/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: USER
 * Data: 2010-08-07
 * Godzina: 17:19
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageViewer.Plugins.Intefaces
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface IPluginInterface
	{
		void Init(MenuStrip menuStrip);
		bool ProcessImage(Graphics g);	
	}
}

