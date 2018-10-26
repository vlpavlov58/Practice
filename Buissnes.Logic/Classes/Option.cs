using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buissnes.Logic.Classes
{
    public abstract class Option
    {
        public string Text { get; set; }

        public TextItem TextItem { get; set; }
    }

    public sealed class RadioButton : Option { }

    public sealed class CheckBox : Option { }
}
