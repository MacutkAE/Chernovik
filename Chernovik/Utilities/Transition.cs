using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chernovik.Entities;
using System.Windows.Controls;

namespace Chernovik.Utilities
{
    internal class Transition
    {
        public static Frame mainFrame { get; set; }
        private static DraftEntities1 _context {  get; set; }
        public static DraftEntities1 Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new DraftEntities1();
                }
                return _context;
            }
        }
    }
}
