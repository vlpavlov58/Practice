using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buissnes.Logic.Classes
{
    public abstract class SurveyItem
    {
        public int ID { get; set; }

        public int Order { get; set; }

        public bool IsDeleted { get; set; }

        protected abstract bool Validate();

        public virtual SurveyItem Copy()
        {
            return this;
        }
    }
}
