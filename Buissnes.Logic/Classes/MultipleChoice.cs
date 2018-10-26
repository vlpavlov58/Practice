using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buissnes.Logic.Classes
{
    public class MultipleChoice : SurveyItem
    {
        private Option[] _items;

        public Option[] Items
        {
            get
            {
                return _items;
            }

            set
            {
                if (_items != null)
                {
                    _items = value;
                }
            }
        }

        public string Caption { get; set; }

        public MultipleChoice() : base()
        {
        }

        public MultipleChoice(int size)
        {
            Items = new Option[size];
        }

        protected override bool Validate()
        {
            return _items?.Length > 0;
        }
    }
}
