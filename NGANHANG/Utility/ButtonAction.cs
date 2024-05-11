using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.Utility
{
    public class ButtonAction
    {
        public ButtonActionType ActionType { get; set; }

        public object[] SaveItems { get; set; }

        public ButtonAction(ButtonActionType actionType, object[] saveItems)
        {
            this.ActionType = actionType;
            this.SaveItems = saveItems;
        }
    }
}
