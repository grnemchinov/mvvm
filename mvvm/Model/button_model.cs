using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace mvvm
{
    public class button_model
    {
        public List<Button> buttons;
        public List<RadioButton> krornol;
        public button_model() 
        {
            buttons = new List<Button> { Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9 };
            krornol = new List<RadioButton> { krest, nol };
        }

        public Button Button1 { get; set; }
        public Button Button2 { get; set; }
        public Button Button3 { get; set; }
        public Button Button4 { get; set; }
        public Button Button5 { get; set; }
        public Button Button6 { get; set; }
        public Button Button7 { get; set; }
        public Button Button8 { get; set; }
        public Button Button9 { get; set; }
        public RadioButton krest { get; set; }
        public RadioButton nol { get; set; }

    }
}
