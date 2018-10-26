using Buissnes.Logic.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buissnes.Logic.Classes
{
    public class TextItem : SurveyItem
    {
        public string Text { get; set; }

        public DataType DataType { get; set; }

        public int RowCount { get; set; } = 1;

        protected override bool Validate()
        {
            bool result = false;

            switch (DataType)
            {
                case DataType.IntType:
                   result = int.TryParse(Text, out int val);
                    break;
                case DataType.DateType:
                    result = DateTime.TryParse(Text, out DateTime dateVal);
                    break;
                default:
                    result = !string.IsNullOrWhiteSpace(Text);
                    break;
            }
            return result;
        }
    }
}
