/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: USER
 * Data: 2010-08-07
 * Godzina: 17:19
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
using System;
using System.Collections.Generic;
using System.Drawing;

using ImageViewer.Plugins.Intefaces;

namespace ImagePlugin
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class DrawRectangle : IPluginInterface 
	{
		
		
		public bool ProcessImage(Graphics g)
  		{
            g.FillRectangle(Brushes.Red, 25, 25, 150, 150);
            return true;
        }
		
		public void Init(System.Windows.Forms.MenuStrip menuStrip)
		{
			menuStrip.a
		}
	}
}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using ImageViewer.Plugins.Intefaces;
namespace ImagePlugin
{
    public class DrawRectangle : IPluginInterface 
    {

        #region IPluginInterface Members

        public bool ProcessImage(Graphics g)
        {
            g.FillRectangle(Brushes.Red, 25, 25, 150, 150);
            return true;
        }

        #endregion
    }
}
*/